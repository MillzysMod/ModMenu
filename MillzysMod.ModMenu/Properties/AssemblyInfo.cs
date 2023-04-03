using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using MillzysMod.ModMenu;
using BuildInfo = MillzysMod.ModMenu.Properties.BuildInfo;

[assembly: AssemblyTitle(BuildInfo.ID)]
[assembly: AssemblyDescription(BuildInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(BuildInfo.Name)]
[assembly: AssemblyCopyright("Copyright © " + BuildInfo.Author + " 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("6FA16024-6104-480D-AD37-965E49370723")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: MelonInfo(typeof(Mod), BuildInfo.Name, BuildInfo.Version, BuildInfo.Author)]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]