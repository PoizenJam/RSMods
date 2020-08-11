﻿using System;
using System.IO;
using System.Windows.Forms;

namespace RS2014_Mod_Installer
{
    class Worker
    {
        public static string WhereIsRocksmith()
        {
            return RSMods.Util.GenUtil.GetRSDirectory();
        }
    }
    class DLLStuff
    {
        public static void InjectDLL(string rocksmithLocation)
        {
            File.WriteAllBytes(Path.Combine(@rocksmithLocation, "D3DX9_42.dll"), Properties.Resources.D3DX9_42);
            Environment.Exit(1);
        }

        public static void InjectGUI(string rocksmithLocation)
        {
            string rootModFolder = Path.Combine(rocksmithLocation, "RSMods");
            string customModsFolder = Path.Combine(rootModFolder, "CustomMods");
            string ddcFolder = Path.Combine(rootModFolder, "ddc");
            string toolsFolder = Path.Combine(rootModFolder, "tools");

            Directory.CreateDirectory(rootModFolder);
            Directory.CreateDirectory(customModsFolder);
            Directory.CreateDirectory(ddcFolder);
            Directory.CreateDirectory(toolsFolder);

            // Root Folder
                File.WriteAllBytes(Path.Combine(rootModFolder, "7z.dll"), Properties.Resources._7z);
                File.WriteAllBytes(Path.Combine(rootModFolder, "ICSharpCode.SharpZipLib.dll"), Properties.Resources.ICSharpCode_SharpZipLib);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.dll"), Properties.Resources.Microsoft_WindowsAPICodePack);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.pdb"), Properties.Resources.Microsoft_WindowsAPICodePack1);
                File.WriteAllText(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.xml"), Properties.Resources.Microsoft_WindowsAPICodePack2);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.Shell.dll"), Properties.Resources.Microsoft_WindowsAPICodePack_Shell);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.Shell.pdb"), Properties.Resources.Microsoft_WindowsAPICodePack_Shell1);
                File.WriteAllText(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.Shell.xml"), Properties.Resources.Microsoft_WindowsAPICodePack_Shell2);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.ShellExtensions.dll"), Properties.Resources.Microsoft_WindowsAPICodePack_ShellExtensions);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.ShellExtensions.pdb"), Properties.Resources.Microsoft_WindowsAPICodePack_ShellExtensions1);
                File.WriteAllText(Path.Combine(rootModFolder, "Microsoft.WindowsAPICodePack.ShellExtensions.xml"), Properties.Resources.Microsoft_WindowsAPICodePack_ShellExtensions2);
                File.WriteAllBytes(Path.Combine(rootModFolder, "MiscUtil.dll"), Properties.Resources.MiscUtil);
                File.WriteAllBytes(Path.Combine(rootModFolder, "NDesk.Options.dll"), Properties.Resources.NDesk_Options);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Newtonsoft.Json.dll"), Properties.Resources.Newtonsoft_Json);
                File.WriteAllBytes(Path.Combine(rootModFolder, "NLog.dll"), Properties.Resources.NLog);
                File.WriteAllBytes(Path.Combine(rootModFolder, "Ookii.Dialogs.dll"), Properties.Resources.Ookii_Dialogs);
                File.WriteAllBytes(Path.Combine(rootModFolder, "PSTaskDialog.dll"), Properties.Resources.PSTaskDialog);
                File.WriteAllBytes(Path.Combine(rootModFolder, "RocksmithToolkitLib.dll"), Properties.Resources.RocksmithToolkitLib);
                File.WriteAllBytes(Path.Combine(rootModFolder, "RocksmithToTabLib.dll"), Properties.Resources.RocksmithToTabLib);
                File.WriteAllBytes(Path.Combine(rootModFolder, "RSMods.exe"), Properties.Resources.RSMods);
                File.WriteAllText(Path.Combine(rootModFolder, "RSMods.exe.config"), Properties.Resources.RSMods_exe);
                File.WriteAllBytes(Path.Combine(rootModFolder, "RSMods.pdb"), Properties.Resources.RSMods1);
                File.WriteAllBytes(Path.Combine(rootModFolder, "SevenZipSharp.dll"), Properties.Resources.SevenZipSharp);
                File.WriteAllBytes(Path.Combine(rootModFolder, "SharpConfig.dll"), Properties.Resources.SharpConfig);
                File.WriteAllBytes(Path.Combine(rootModFolder, "X360.dll"), Properties.Resources.X360);
                File.WriteAllBytes(Path.Combine(rootModFolder, "zlib.net.dll"), Properties.Resources.zlib_net);
            // ddc Folder
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc.exe"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_chords_protector.xml"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_chords_remover.xml"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_dd_remover.xml"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_default.cfg"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_default.xml"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_keep_all_levels.cfg"), Properties.Resources.ddc);
                File.WriteAllBytes(Path.Combine(ddcFolder, "ddc_merge_all_levels.cfg"), Properties.Resources.ddc);
                File.WriteAllText(Path.Combine(ddcFolder, "license.txt"), Properties.Resources.license);
                File.WriteAllText(Path.Combine(ddcFolder, "readme.txt"), Properties.Resources.readme1);
            // tools Folder
                File.WriteAllBytes(Path.Combine(toolsFolder, "7za.exe"), Properties.Resources._7za);
                File.WriteAllBytes(Path.Combine(toolsFolder, "core.jar"), Properties.Resources.core);
                File.WriteAllBytes(Path.Combine(toolsFolder, "CreateToolkitShortcut.exe"), Properties.Resources.CreateToolkitShortcut);
                File.WriteAllBytes(Path.Combine(toolsFolder, "nvdxt.exe"), Properties.Resources.nvdxt);
                File.WriteAllBytes(Path.Combine(toolsFolder, "oggCut.exe"), Properties.Resources.oggCut);
                File.WriteAllBytes(Path.Combine(toolsFolder, "oggdec.exe"), Properties.Resources.oggdec);
                File.WriteAllBytes(Path.Combine(toolsFolder, "oggenc.exe"), Properties.Resources.oggenc);
                File.WriteAllText(Path.Combine(toolsFolder, "OpenCmd.bat"), Properties.Resources.OpenCmd);
                File.WriteAllBytes(Path.Combine(toolsFolder, "packed_codebooks.bin"), Properties.Resources.packed_codebooks);
                File.WriteAllBytes(Path.Combine(toolsFolder, "packed_codebooks_aoTuV_603.bin"), Properties.Resources.packed_codebooks_aoTuV_603);
                File.WriteAllText(Path.Combine(toolsFolder, "readme.txt"), Properties.Resources.readme);
                File.WriteAllBytes(Path.Combine(toolsFolder, "revorb.exe"), Properties.Resources.revorb);
                File.WriteAllBytes(Path.Combine(toolsFolder, "topng.exe"), Properties.Resources.topng);
                File.WriteAllBytes(Path.Combine(toolsFolder, "ww2ogg.exe"), Properties.Resources.ww2ogg);

        }
    }
} 