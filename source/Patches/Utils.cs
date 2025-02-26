using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Hazel;
using Reactor.Extensions;
using TownOfUs.MedicMod;
using TownOfUs.Roles;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TownOfUs
{
    [HarmonyPatch]
    public static class Utils
    {


        public static void Morph(PlayerControl Player, PlayerControl MorphedPlayer, bool resetAnim = false)
        {
            if (CamouflageMod.CamouflageUnCamouflage.IsCamoed)
            {
                return;
            }

            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Seer))
            {
                Player.nameText.Text = MorphedPlayer.Data.PlayerName;
            }

            var colorId = MorphedPlayer.Data.ColorId;
            PlayerControl.SetPlayerMaterialColors(colorId, Player.myRend);
            Player.HatRenderer.SetHat(MorphedPlayer.Data.HatId, colorId);
            Player.nameText.transform.localPosition = new Vector3(0f, (Player.Data.HatId == 0U) ? 0.7f : 1.05f, -0.5f);

            if (Player.MyPhysics.Skin.skin.ProdId != DestroyableSingleton<HatManager>.Instance
                .AllSkins[(int) MorphedPlayer.Data.SkinId].ProdId)
            {
                Player.MyPhysics.SetSkin(MorphedPlayer.Data.SkinId);
            }

            if (Player.CurrentPet == null || Player.CurrentPet.ProdId !=
                DestroyableSingleton<HatManager>.Instance.AllPets[(int) MorphedPlayer.Data.PetId].ProdId)
            {

                if (Player.CurrentPet != null)
                {
                    Object.Destroy(Player.CurrentPet.gameObject);
                }

                Player.CurrentPet =
                    Object.Instantiate(
                        DestroyableSingleton<HatManager>.Instance.AllPets[(int) MorphedPlayer.Data.PetId]);
                Player.CurrentPet.transform.position = Player.transform.position;
                Player.CurrentPet.Source = Player;
                Player.CurrentPet.Visible = Player.Visible;
            }

            PlayerControl.SetPlayerMaterialColors(colorId, Player.CurrentPet.rend);
            if (resetAnim && !Player.inVent)
            {
                Player.MyPhysics.ResetAnim();
            }
        }

        public static void Unmorph(PlayerControl Player)
        {
            var colorId = Player.Data.ColorId;
            Player.nameText.Text = Player.Data.PlayerName;
            PlayerControl.SetPlayerMaterialColors(colorId, Player.myRend);
            Player.HatRenderer.SetHat(Player.Data.HatId, colorId);
            Player.nameText.transform.localPosition = new Vector3(0f, (Player.Data.HatId == 0U) ? 0.7f : 1.05f, -0.5f);

            if (Player.MyPhysics.Skin.skin.ProdId != DestroyableSingleton<HatManager>.Instance
                .AllSkins[(int) Player.Data.SkinId].ProdId)
            {
                Player.MyPhysics.SetSkin(Player.Data.SkinId);
            }


            if (Player.CurrentPet != null)
            {
                Object.Destroy(Player.CurrentPet.gameObject);
            }

            Player.CurrentPet =
                Object.Instantiate(
                    DestroyableSingleton<HatManager>.Instance.AllPets[(int) Player.Data.PetId]);
            Player.CurrentPet.transform.position = Player.transform.position;
            Player.CurrentPet.Source = Player;
            Player.CurrentPet.Visible = Player.Visible;


            PlayerControl.SetPlayerMaterialColors(colorId, Player.CurrentPet.rend);

            if (!Player.inVent)
            {
                Player.MyPhysics.ResetAnim();
            }
        }

        public static bool IsLastImp(PlayerControl player)
        {
            if (!player.Data.IsImpostor) return false;
            var imps = PlayerControl.AllPlayerControls.ToArray()
                .Where(x => x.Data.IsImpostor && !x.Data.IsDead && !x.Data.Disconnected);
            return imps.Count() == 1;

        }

        public static void Camouflage()
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                player.nameText.Text = "";
                PlayerControl.SetPlayerMaterialColors(Color.grey, player.myRend);
                player.HatRenderer.SetHat(0, 0);
                if (player.MyPhysics.Skin.skin.ProdId != DestroyableSingleton<HatManager>.Instance
                    .AllSkins[0].ProdId)
                {
                    player.MyPhysics.SetSkin(0);
                }

                if (player.CurrentPet != null)
                {
                    Object.Destroy(player.CurrentPet.gameObject);
                }

            }
        }

        public static void UnCamouflage()
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                Unmorph(player);
            }
        }


        public static Dictionary<PlayerControl, Color> oldColors = new Dictionary<PlayerControl, Color>();

        public static List<WinningPlayerData> potentialWinners = new List<WinningPlayerData>();


        public static bool IsCrewmate(this PlayerControl player)
        {
            return GetRole(player) == RoleEnum.Crewmate;
        }


        public static bool isLover(this PlayerControl player)
        {
            return player.Is(RoleEnum.Lover) || player.Is(RoleEnum.LoverImpostor);
        }

        public static bool Is(this PlayerControl player, RoleEnum roleType)
        {
            return Roles.Role.GetRole(player)?.RoleType == roleType;
        }

        public static bool Is(this PlayerControl player, ModifierEnum modifierType)
        {
            return Modifier.GetModifier(player)?.ModifierType == modifierType;
        }

        public static RoleEnum GetRole(PlayerControl player)
        {
            if (player == null) return RoleEnum.None;
            if (player.Data == null) return RoleEnum.None;

            var role = Roles.Role.GetRole(player);
            if (role != null)
            {
                return role.RoleType;
            }

            return player.Data.IsImpostor ? RoleEnum.Impostor : RoleEnum.Crewmate;
        }

        public static PlayerControl PlayerById(byte id)
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player.PlayerId == id)
                {
                    return player;
                }
            }

            return null;
        }

        public static List<PlayerControl> getCrewmates(IEnumerable<GameData.PlayerInfo> infection)
        {
            var list = new List<PlayerControl>();
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                var isImpostor = false;
                foreach (var impostor in infection)
                {
                    if (player.PlayerId == impostor.Object.PlayerId)
                    {
                        isImpostor = true;
                    }
                }

                if (!isImpostor)
                {
                    list.Add(player);
                }

            }

            return list;
        }

        public static bool isShielded(this PlayerControl player)
        {
            return Role.GetRoles(RoleEnum.Medic).Any(role =>
            {
                var shieldedPlayer = ((Roles.Medic) role).ShieldedPlayer;
                return shieldedPlayer != null && player.PlayerId == shieldedPlayer.PlayerId;
            });
        }

        public static List<PlayerControl> getImpostors(IEnumerable<GameData.PlayerInfo> infection)
        {
            var list = new List<PlayerControl>();
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                var isImpostor = false;
                foreach (var impostor in infection)
                {
                    if (player.PlayerId == impostor.Object.PlayerId)
                    {
                        isImpostor = true;
                    }
                }

                if (isImpostor)
                {
                    list.Add(player);
                }

            }

            return list;
        }

        public static PlayerControl getClosestPlayer(PlayerControl refplayer, List<PlayerControl> AllPlayers)
        {
            var num = double.MaxValue;
            PlayerControl result = null;
            foreach (var player in AllPlayers)
            {
                var flag3 = player.Data.IsDead;
                if (flag3) continue;
                var flag = player.PlayerId != refplayer.PlayerId;
                if (!flag) continue;
                var distBetweenPlayers = getDistBetweenPlayers(player, refplayer);
                var flag2 = distBetweenPlayers < num;
                if (!flag2) continue;
                num = distBetweenPlayers;
                result = player;
            }

            return result;
        }

        public static PlayerControl getClosestPlayer(PlayerControl refplayer)
        {
            return getClosestPlayer(refplayer, PlayerControl.AllPlayerControls.ToArray().ToList());
        }


        public static double getDistBetweenPlayers(PlayerControl player, PlayerControl refplayer)
        {
            var truePosition = refplayer.GetTruePosition();
            var truePosition2 = player.GetTruePosition();
            return Vector2.Distance(truePosition, truePosition2);
        }

        public static void RpcMurderPlayer(PlayerControl killer, PlayerControl target)
        {
            MurderPlayer(killer, target);
            MessageWriter writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                (byte) CustomRPC.BypassKill, Hazel.SendOption.None, -1);
            writer.Write(killer.PlayerId);
            writer.Write(target.PlayerId);
            AmongUsClient.Instance.FinishRpcImmediately(writer);
        }

        public static void MurderPlayer(PlayerControl killer, PlayerControl target)
        {
            GameData.PlayerInfo data = target.Data;
            if (data != null && !data.IsDead)
            {
                if (killer == PlayerControl.LocalPlayer)
                {
                    SoundManager.Instance.PlaySound(PlayerControl.LocalPlayer.KillSfx, false, 0.8f);
                }

                target.gameObject.layer = LayerMask.NameToLayer("Ghost");
                if (target.AmOwner)
                {
                    if (Minigame.Instance)
                    {
                        Minigame.Instance.Close();
                        Minigame.Instance.Close();
                    }

                    if (MapBehaviour.Instance)
                    {
                        MapBehaviour.Instance.Close();
                        MapBehaviour.Instance.Close();
                    }

                    DestroyableSingleton<HudManager>.Instance.KillOverlay.ShowOne(killer.Data, data);
                    DestroyableSingleton<HudManager>.Instance.ShadowQuad.gameObject.SetActive(false);
                    target.nameText.GetComponent<MeshRenderer>().material.SetInt("_Mask", 0);
                    target.RpcSetScanner(false);
                    ImportantTextTask importantTextTask = new GameObject("_Player").AddComponent<ImportantTextTask>();
                    importantTextTask.transform.SetParent(AmongUsClient.Instance.transform, false);
                    if (!PlayerControl.GameOptions.GhostsDoTasks)
                    {
                        for (int i = 0; i < target.myTasks.Count; i++)
                        {
                            PlayerTask playerTask = target.myTasks[i];
                            playerTask.OnRemove();
                            UnityEngine.Object.Destroy(playerTask.gameObject);
                        }

                        target.myTasks.Clear();
                        importantTextTask.Text = DestroyableSingleton<TranslationController>.Instance.GetString(
                            StringNames.GhostIgnoreTasks,
                            new UnhollowerBaseLib.Il2CppReferenceArray<Il2CppSystem.Object>(0));
                    }
                    else
                    {
                        importantTextTask.Text = DestroyableSingleton<TranslationController>.Instance.GetString(
                            StringNames.GhostDoTasks,
                            new UnhollowerBaseLib.Il2CppReferenceArray<Il2CppSystem.Object>(0));
                    }

                    target.myTasks.Insert(0, importantTextTask);
                }

                killer.MyPhysics.StartCoroutine(killer.KillAnimations.Random<KillAnimation>()
                    .CoPerformKill(killer, target));
                var deadBody = new DeadPlayer
                {
                    PlayerId = target.PlayerId,
                    KillerId = killer.PlayerId,
                    KillTime = DateTime.UtcNow,
                };

                Murder.KilledPlayers.Add(deadBody);
                if (!killer.Is(RoleEnum.Glitch) && !killer.Is(RoleEnum.Arsonist))
                {
                    ChildMod.Murder.CheckChild(target);
                }

                if (target.Is(ModifierEnum.Diseased) && killer.Is(RoleEnum.Glitch))
                {
                    var glitch = Roles.Role.GetRole<Roles.Glitch>(killer);
                    glitch.LastKill = DateTime.UtcNow.AddSeconds(2 * CustomGameOptions.GlitchKillCooldown);
                    glitch.Player.SetKillTimer(CustomGameOptions.GlitchKillCooldown * 3);
                }
            }
        }
        
        public static IEnumerator FlashCoroutine(Color color)
        {
            color.a = 0.3f;
            var fullscreen = DestroyableSingleton<HudManager>.Instance.FullScreen;
            fullscreen.enabled = true;
            fullscreen.color = color;
            yield return new WaitForSeconds(1f);
            fullscreen.enabled = false;
        }

        public static IEnumerable<(T1, T2)> Zip<T1, T2>(List<T1> first, List<T2> second)
        {
            return Enumerable.Zip(first, second, (x, y) => (x, y));
        }
        
        public static void DestroyAll(this IEnumerable<Component> listie)
        {
            foreach (var item in listie)
            {
                if (item == null) continue;
                Object.Destroy(item);
                if (item.gameObject == null) return;
                Object.Destroy(item.gameObject);
            }
        }



    }
}