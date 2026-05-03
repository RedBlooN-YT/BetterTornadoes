global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using BetterTornadoes;
using HarmonyLib;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Bloons;

[assembly: MelonInfo(typeof(BetterTornadoes.BetterTornadoes), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BetterTornadoes;

public class BetterTornadoes : BloonsTD6Mod
{

    [HarmonyPatch(typeof(Wind), nameof(Wind.Collide))]
    public static class Wind_Collide_Patch
    {
        public static void Postfix(Wind __instance, Bloon bloon)
        {
            bloon.Move(-50f);
        }
    }
}