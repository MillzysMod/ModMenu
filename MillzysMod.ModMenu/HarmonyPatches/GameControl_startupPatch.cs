using HarmonyLib;
using Il2CppSLZ.Bonelab;
using MelonLoader;

namespace MillzysMod.Modmenu.HarmonyPatches;

[HarmonyPatch(typeof(GameControl_startup))]
[HarmonyPatch("Start")]
// ReSharper disable once InconsistentNaming
public class GameControl_startupPatch
{
    [HarmonyPostfix]
    public static void Postfix()
    {
        
    }
}