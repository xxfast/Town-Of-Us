using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.ArsonistMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        public static Sprite IgniteSprite => TownOfUs.IgniteSprite;

        public static void UpdateMeeting(MeetingHud __instance, Arsonist role)
        {
            foreach (var state in __instance.playerStates)
            {
                var player = PlayerControl.AllPlayerControls.ToArray()
                    .FirstOrDefault(x => x.PlayerId == state.TargetPlayerId);
                if (player == null) continue;
                if (role.DousedPlayers.Contains(player.PlayerId))
                {
                    state.NameText.Color = Color.black;
                }
            }
        }
        
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Arsonist)) return;
            var role = Roles.Role.GetRole<Roles.Arsonist>(PlayerControl.LocalPlayer);
            
            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, role);
            foreach (var playerId in role.DousedPlayers)
            {
                
                var player = Utils.PlayerById(playerId);
                player.myRend.material.SetColor("_VisorColor", role.Color);
                player.nameText.Color = Color.black;
            }
            
            if (role.IgniteButton == null)
            {
                role.IgniteButton = Object.Instantiate(__instance.KillButton);
                role.IgniteButton.renderer.enabled = true;
            }

            var position = __instance.KillButton.transform.position;
            role.IgniteButton.renderer.sprite = IgniteSprite;
            role.IgniteButton.transform.position = new Vector3(position.x,
                __instance.ReportButton.transform.position.y, position.z);

            role.IgniteButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead);
            __instance.KillButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead);
            role.IgniteButton.SetCoolDown(0f, 1f);
            __instance.KillButton.SetCoolDown(role.DouseTimer(), CustomGameOptions.DouseCd);
            role.closestPlayer = Utils.getClosestPlayer(PlayerControl.LocalPlayer);
            var distance = Utils.getDistBetweenPlayers(PlayerControl.LocalPlayer, role.closestPlayer);
            var flag9 = distance < GameOptionsData.KillDistances[PlayerControl.GameOptions.KillDistance];
            if (flag9 && __instance.KillButton.isActiveAndEnabled && !role.IgniteUsed)
            {
                __instance.KillButton.SetTarget(role.closestPlayer);
            }
            else
            {
                __instance.KillButton.SetTarget(null);
            }


            if (!role.IgniteButton.isCoolingDown & role.IgniteButton.isActiveAndEnabled & !role.IgniteUsed &
                role.CheckEveryoneDoused())
            {
                role.IgniteButton.renderer.color = Palette.EnabledColor;
                role.IgniteButton.renderer.material.SetFloat("_Desat", 0f);
                return;
            }
            role.IgniteButton.renderer.color = Palette.DisabledColor;
            role.IgniteButton.renderer.material.SetFloat("_Desat", 1f);

            
            
        }

    }
}