using System.Linq;
using HarmonyLib;
using UnityEngine;

namespace TownOfUs.MinerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        public static Sprite MineSprite => TownOfUs.MineSprite;

        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Miner)) return;
            var role = Roles.Role.GetRole<Roles.Miner>(PlayerControl.LocalPlayer);
            if (role.MineButton == null)
            {
                role.MineButton = Object.Instantiate(__instance.KillButton);
                role.MineButton.renderer.enabled = true;
                
            }
            role.MineButton.renderer.sprite = MineSprite;
            role.MineButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead);
            var position = __instance.KillButton.transform.position;
            role.MineButton.transform.position = new Vector3(position.x,
                __instance.ReportButton.transform.position.y, position.z);
            role.MineButton.SetCoolDown(role.MineTimer(), CustomGameOptions.MineCd);
            
            var hits = Physics2D.OverlapBoxAll(PlayerControl.LocalPlayer.transform.position, role.VentSize, 0);
            hits = hits.ToArray().Where((c) => (c.name.Contains("Vent") || !c.isTrigger) && c.gameObject.layer != 8 && c.gameObject.layer != 5).ToArray();
            if (hits.Count == 0)
            {
                role.MineButton.renderer.color = Palette.EnabledColor;
                role.MineButton.renderer.material.SetFloat("_Desat", 0f);
                role.CanPlace = true;
            }
            else
            {
                role.MineButton.renderer.color = Palette.DisabledColor;
                role.MineButton.renderer.material.SetFloat("_Desat", 1f);
                role.CanPlace = false;
            }
           

        }
    }
}