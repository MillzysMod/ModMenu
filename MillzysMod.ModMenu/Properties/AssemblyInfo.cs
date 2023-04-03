using System.Reflection;
using MelonLoader;
using MillzysMod.Modmenu;
using BuildInfo = MillzysMod.Modmenu.Properties.BuildInfo;

[assembly: AssemblyTitle("MillzysMod.ModMenu")]
[assembly: AssemblyDescription("Adds an additional menu that displays currently installed mods (and any errors) in the main menu.")]
[assembly: AssemblyProduct("Millzy's ModMenu")]
[assembly: AssemblyCopyright("Copyright © Millzy 2023")]

[assembly: AssemblyVersion(BuildInfo.Version)]
[assembly: AssemblyFileVersion(BuildInfo.Version)]

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(null!)]
[assembly: AssemblyTrademark(null!)]
[assembly: AssemblyCulture("")]

[assembly: MelonInfo(typeof(Mod), "Millzy's ModMenu", BuildInfo.Version, "Millzy")]