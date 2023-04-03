using HarmonyLib;
using MillzysMod.ModMenu.CustomTypes;
using SLZ.Bonelab;

namespace MillzysMod.ModMenu.HarmonyPatches
{
    [HarmonyPatch(typeof(GameControl_startup), "Start")]
    public static class GameControl_startupPatch
    {
        [HarmonyPostfix]
        public static void Postfix() => MainMenuModifier.Begin();
    }
}