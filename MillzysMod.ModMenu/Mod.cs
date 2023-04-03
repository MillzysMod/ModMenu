using Harmony;
using MelonLoader;
using BuildInfo = MillzysMod.ModMenu.Properties.BuildInfo;

namespace MillzysMod.ModMenu
{
    public class Mod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
            MelonLogger.Msg($"Finished initialising {nameof(ModMenu)}.");
        }
    }
}
