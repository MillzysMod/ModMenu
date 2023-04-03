using HarmonyLib;
using MillzysMod.ModMenu.CustomTypes;
using SLZ.Bonelab;

namespace MillzysMod.ModMenu.HarmonyPatches
{
    [HarmonyPatch(typeof(GameControl_MenuVoidG114), "Start")]
    public static class GameControl_MenuVoidG114Patch
    {
        [HarmonyPostfix]
        public static void Postfix() => MainMenuModifier.Begin();
    }
}