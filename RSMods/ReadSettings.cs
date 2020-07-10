﻿using System.IO;

namespace RSMods
{
    class ReadSettings
    {
        public static string Songlist1Name, Songlist2Name, Songlist3Name, Songlist4Name, Songlist5Name, Songlist6Name,
                             ToggleLoftKey, AddVolumeKey, DecreaseVolumeKey, ShowSongTimerKey, ForceReEnumerationKey, RainbowStringsKey,
                             ToggleLoftEnabled, AddVolumeEnabled, DecreaseVolumeEnabled, ShowSongTimerEnabled, ForceReEnumerationEnabled, RainbowStringsEnabled, ExtendedRangeEnabled, CustomStringColorsNumber, DiscoModeEnabled, RemoveHeadstockEnabled, RemoveSkylineEnabled, GreenscreenWallEnabled, ForceProfileEnabled, FretlessEnabled, RemoveInlaysEnabled, ToggleLoftWhen, ToggleSkylineWhen, RemoveLaneMarkersEnabled,
                             String0Color_N, String1Color_N, String2Color_N, String3Color_N, String4Color_N, String5Color_N, String0Color_CB, String1Color_CB, String2Color_CB, String3Color_CB, String4Color_CB, String5Color_CB,
                             ExtendedRangeTuning, CheckForNewSongInterval, 
                             RocksmithInstallLocation;

        public static string
            // Song List Identifiers
                Songlist1Identifier = "SongListTitle_1 = ",
                Songlist2Identifier = "SongListTitle_2 = ",
                Songlist3Identifier = "SongListTitle_3 = ",
                Songlist4Identifier = "SongListTitle_4 = ",
                Songlist5Identifier = "SongListTitle_5 = ",
                Songlist6Identifier = "SongListTitle_6 = ",
            // Toggle On Key Identifiers
                ToggleLoftIdentifier         = "ToggleLoftKey = ",
                AddVolumeIdentifier          = "AddVolumeKey = ",
                DecreaseVolumeIdentifier     = "DecreaseVolumeKey = ",
                ShowSongTimerIdentifier      = "ShowSongTimerKey = ",
                ForceReEnumerationIdentifier = "ForceReEnumerationKey = ",
                RainbowStringsIdentifier     = "RainbowStringsKey = ",
            // Toggle Effects (Change Names to easier naming scheme before public launch)
                ToggleLoftEnabledIdentifier         = "ToggleLoftEnabled = ",
                AddVolumeEnabledIdentifier          = "AddVolumeEnabled = ",
                DecreaseVolumeEnabledIdentifier     = "DecreaseVolumeEnabled = ",
                ShowSongTimerEnabledIdentifier      = "ShowSongTimerEnabled = ",
                ForceReEnumerationEnabledIdentifier = "ForceReEnumerationEnabled = ",
                RainbowStringsEnabledIdentifier     = "RainbowStringsEnabled = ",
                ExtendedRangeEnabledIdentifier      = "ExtendedRangeEnabled = ",
                CustomStringColorNumberIndetifier = "CustomStringColors = ",
                DiscoModeIdentifier                 = "DiscoModeEnabled = ",
                RemoveHeadstockIdentifier           = "RemoveHeadstockEnabled = ",
                RemoveSkylineIdentifier             = "RemoveSkylineEnabled = ",
                GreenScreenWallIdentifier           = "GreenScreenWallEnabled = ",
                ForceProfileEnabledIdentifier       = "ForceProfileEnabled = ",
                FretlessModeEnabledIdentifier       = "FretlessModeEnabled = ",
                RemoveInlaysIdentifier              = "RemoveInlaysEnabled = ",
                ToggleLoftWhenIdentifier            = "ToggleLoftWhen = ",
                ToggleSkylineWhenIdentifier         = "ToggleSkylineWhen = ",
                RemoveLaneMarkersIdentifier         = "RemoveLaneMarkersEnabled = ",
            // String Colors (Normal {N} & Colorblind {CB})
                // Normal String Colors
                    String0Color_N_Identifier   = "string0_N = ",
                    String1Color_N_Identifier   = "string1_N = ",
                    String2Color_N_Identifier   = "string2_N = ",
                    String3Color_N_Identifier   = "string3_N = ",
                    String4Color_N_Identifier   = "string4_N = ",
                    String5Color_N_Identifier   = "string5_N = ",
                // Colorblind String Colors
                    String0Color_CB_Identifier  = "string1_CB = ",
                    String1Color_CB_Identifier  = "string2_CB = ",
                    String2Color_CB_Identifier  = "string2_CB = ",
                    String3Color_CB_Identifier  = "string3_CB = ",
                    String4Color_CB_Identifier  = "string4_CB = ",
                    String5Color_CB_Identifier  = "string5_CB = ",
            // Mod Settings
                ExtendedRangeTuningIdentifier     = "ExtendedRangeModeAt = ",
                CheckForNewSongIntervalIdentifier = "CheckForNewSongsInterval = ",
                


            RocksmithInstallLocationIdentifier = "RocksmithIsInstalledAt = ";

        public static string ProcessSettings(int grab)
        {
            foreach (string currentLine in File.ReadLines(@WriteSettings.dumpLocation))
            {
                // Song Lists
                {
                    if (currentLine.Contains(Songlist1Identifier))
                    {
                        Songlist1Name = currentLine.Substring(Songlist1Identifier.Length, (currentLine.Length - Songlist1Identifier.Length));
                        if (grab == 0)
                        {
                            return Songlist1Name;
                        }
                    }
                    if (currentLine.Contains(Songlist2Identifier))
                    {
                        Songlist2Name = currentLine.Substring(Songlist2Identifier.Length, (currentLine.Length - Songlist2Identifier.Length));
                        if (grab == 1)
                        {
                            return Songlist2Name;
                        }
                    }
                    if (currentLine.Contains(Songlist3Identifier))
                    {
                        Songlist3Name = currentLine.Substring(Songlist3Identifier.Length, (currentLine.Length - Songlist3Identifier.Length));
                        if (grab == 2)
                        {
                            return Songlist3Name;
                        }
                    }
                    if (currentLine.Contains(Songlist4Identifier))
                    {
                        Songlist4Name = currentLine.Substring(Songlist4Identifier.Length, (currentLine.Length - Songlist4Identifier.Length));
                        if (grab == 3)
                        {
                            return Songlist4Name;
                        }
                    }
                    if (currentLine.Contains(Songlist5Identifier))
                    {
                        Songlist5Name = currentLine.Substring(Songlist5Identifier.Length, (currentLine.Length - Songlist5Identifier.Length));
                        if (grab == 4)
                        {
                            return Songlist5Name;
                        }
                    }
                    if (currentLine.Contains(Songlist6Identifier))
                    {
                        Songlist6Name = currentLine.Substring(Songlist6Identifier.Length, (currentLine.Length - Songlist6Identifier.Length));
                        if (grab == 5)
                        {
                            return Songlist6Name;
                        }
                    }
                }

                // Mods
                {
                    if (currentLine.Contains(ToggleLoftIdentifier))
                    {
                        ToggleLoftKey = currentLine.Substring(ToggleLoftIdentifier.Length, (currentLine.Length - ToggleLoftIdentifier.Length));
                        if (KeyConversion.VirtualKey(ToggleLoftKey) != "")
                        {
                            ToggleLoftKey = KeyConversion.VirtualKey(ToggleLoftKey);
                        }
                        if (grab == 6)
                        {
                            return ToggleLoftKey;
                        }
                    }
                    if (currentLine.Contains(AddVolumeIdentifier))
                    {
                        AddVolumeKey = currentLine.Substring(AddVolumeIdentifier.Length, (currentLine.Length - AddVolumeIdentifier.Length));
                        if (KeyConversion.VirtualKey(AddVolumeKey) != "")
                        {
                            AddVolumeKey = KeyConversion.VirtualKey(AddVolumeKey);
                        }
                        if (grab == 7)
                        {
                            return AddVolumeKey;
                        }
                    }
                    if (currentLine.Contains(DecreaseVolumeIdentifier))
                    {
                        DecreaseVolumeKey = currentLine.Substring(DecreaseVolumeIdentifier.Length, (currentLine.Length - DecreaseVolumeIdentifier.Length));
                        if (KeyConversion.VirtualKey(DecreaseVolumeKey) != "")
                        {
                            DecreaseVolumeKey = KeyConversion.VirtualKey(DecreaseVolumeKey);
                        }
                        if (grab == 8)
                        {
                            return DecreaseVolumeKey;
                        }
                    }
                    if (currentLine.Contains(ShowSongTimerIdentifier))
                    {
                        ShowSongTimerKey = currentLine.Substring(ShowSongTimerIdentifier.Length, (currentLine.Length - ShowSongTimerIdentifier.Length));
                        if (KeyConversion.VirtualKey(ShowSongTimerKey) != "")
                        {
                            ShowSongTimerKey = KeyConversion.VirtualKey(ShowSongTimerKey);
                        }
                        if (grab == 9)
                        {
                            return ShowSongTimerKey;
                        }
                    }
                    if (currentLine.Contains(ForceReEnumerationIdentifier))
                    {
                        ForceReEnumerationKey = currentLine.Substring(ForceReEnumerationIdentifier.Length, (currentLine.Length - ForceReEnumerationIdentifier.Length));
                        if (KeyConversion.VirtualKey(ForceReEnumerationKey) != "")
                        {
                            ForceReEnumerationKey = KeyConversion.VirtualKey(ForceReEnumerationKey);

                        }
                        if (grab == 10)
                        {
                            return ForceReEnumerationKey;
                        }
                    }
                    if (currentLine.Contains(RainbowStringsIdentifier))
                    {
                        RainbowStringsKey = currentLine.Substring(RainbowStringsIdentifier.Length, (currentLine.Length - RainbowStringsIdentifier.Length));
                        if (KeyConversion.VirtualKey(RainbowStringsKey) != "")
                        {
                            RainbowStringsKey = KeyConversion.VirtualKey(RainbowStringsKey);
                        }
                        if (grab == 16)
                        {
                            return RainbowStringsKey;
                        }
                    }
                }

                // Mods Enabled / Disabled
                {
                    if (currentLine.Contains(ToggleLoftEnabledIdentifier))
                    {
                        if (currentLine.Substring(ToggleLoftEnabledIdentifier.Length, (currentLine.Length - ToggleLoftEnabledIdentifier.Length)) == "true")
                        {
                            ToggleLoftEnabled = "true";
                        }
                        else
                        {
                            ToggleLoftEnabled = "false";
                        }

                        if (grab == 11)
                        {
                            return ToggleLoftEnabled;
                        }
                    }
                    if (currentLine.Contains(AddVolumeEnabledIdentifier))
                    {
                        if (currentLine.Substring(AddVolumeEnabledIdentifier.Length, (currentLine.Length - AddVolumeEnabledIdentifier.Length)) == "true")
                        {
                            AddVolumeEnabled = "true";
                        }
                        else
                        {
                            AddVolumeEnabled = "false";
                        }

                        if (grab == 12)
                        {
                            return AddVolumeEnabled;
                        }
                    }
                    if (currentLine.Contains(DecreaseVolumeEnabledIdentifier))
                    {
                        if (currentLine.Substring(DecreaseVolumeEnabledIdentifier.Length, (currentLine.Length - DecreaseVolumeEnabledIdentifier.Length)) == "true")
                        {
                            DecreaseVolumeEnabled = "true";
                        }
                        else
                        {
                            DecreaseVolumeEnabled = "false";
                        }

                        if (grab == 13)
                        {
                            return DecreaseVolumeEnabled;
                        }
                    }
                    if (currentLine.Contains(ShowSongTimerEnabledIdentifier))
                    {
                        if (currentLine.Substring(ShowSongTimerEnabledIdentifier.Length, (currentLine.Length - ShowSongTimerEnabledIdentifier.Length)) == "true")
                        {
                            ShowSongTimerEnabled = "true";
                        }
                        else
                        {
                            ShowSongTimerEnabled = "false";
                        }

                        if (grab == 14)
                        {
                            return ShowSongTimerEnabled;
                        }
                    }
                    if (currentLine.Contains(ForceReEnumerationEnabledIdentifier))
                    {
                        if (currentLine.Substring(ForceReEnumerationEnabledIdentifier.Length, (currentLine.Length - ForceReEnumerationEnabledIdentifier.Length)) == "manual")
                        {
                            ForceReEnumerationEnabled = "manual";
                        }
                        if (currentLine.Substring(ForceReEnumerationEnabledIdentifier.Length, (currentLine.Length - ForceReEnumerationEnabledIdentifier.Length)) == "automatic")
                        {
                            ForceReEnumerationEnabled = "automatic";
                        }
                        if (currentLine.Substring(ForceReEnumerationEnabledIdentifier.Length, (currentLine.Length - ForceReEnumerationEnabledIdentifier.Length)) == "false")
                        {
                            ForceReEnumerationEnabled = "false";
                        }

                        if (grab == 15)
                        {
                            return ForceReEnumerationEnabled;
                        }
                    }
                    if (currentLine.Contains(RainbowStringsEnabledIdentifier))
                    {
                        if (currentLine.Substring(RainbowStringsEnabledIdentifier.Length, (currentLine.Length - RainbowStringsEnabledIdentifier.Length)) == "true")
                        {
                            RainbowStringsEnabled = "true";
                        }
                        else
                        {
                            RainbowStringsEnabled = "false";
                        }

                        if (grab == 17)
                        {
                            return RainbowStringsEnabled;
                        }
                    }
                    if (currentLine.Contains(ExtendedRangeEnabledIdentifier))
                    {
                        if (currentLine.Substring(ExtendedRangeEnabledIdentifier.Length, (currentLine.Length - ExtendedRangeEnabledIdentifier.Length)) == "true")
                        {
                            ExtendedRangeEnabled = "true";
                        }
                        else
                        {
                            ExtendedRangeEnabled = "false";
                        }

                        if (grab == 18)
                        {
                            return ExtendedRangeEnabled;
                        }
                    }
                    if (currentLine.Contains(CustomStringColorNumberIndetifier))
                    {
                        CustomStringColorsNumber = currentLine.Substring(CustomStringColorNumberIndetifier.Length, (currentLine.Length - CustomStringColorNumberIndetifier.Length));

                        if (grab == 43)
                        {
                            return CustomStringColorsNumber;
                        }
                    }
                    if (currentLine.Contains(DiscoModeIdentifier))
                    {
                        if (currentLine.Substring(DiscoModeIdentifier.Length, (currentLine.Length - DiscoModeIdentifier.Length)) == "true")
                        {
                            DiscoModeEnabled = "true";
                        }
                        else
                        {
                            DiscoModeEnabled = "false";
                        }

                        if (grab == 20)
                        {
                            return DiscoModeEnabled;
                        }
                    }
                    if (currentLine.Contains(RemoveHeadstockIdentifier))
                    {
                        if (currentLine.Substring(RemoveHeadstockIdentifier.Length, (currentLine.Length - RemoveHeadstockIdentifier.Length)) == "true")
                        {
                            RemoveHeadstockEnabled = "true";
                        }
                        else
                        {
                            RemoveHeadstockEnabled = "false";
                        }

                        if (grab == 21)
                        {
                            return RemoveHeadstockEnabled;
                        }
                    }
                    if (currentLine.Contains(RemoveSkylineIdentifier))
                    {
                        if (currentLine.Substring(RemoveSkylineIdentifier.Length, (currentLine.Length - RemoveSkylineIdentifier.Length)) == "true")
                        {
                            RemoveSkylineEnabled = "true";
                        }
                        else
                        {
                            RemoveSkylineEnabled = "false";
                        }

                        if (grab == 22)
                        {
                            return RemoveSkylineEnabled;
                        }
                    }
                    if (currentLine.Contains(GreenScreenWallIdentifier))
                    {
                        if (currentLine.Substring(GreenScreenWallIdentifier.Length, (currentLine.Length - GreenScreenWallIdentifier.Length)) == "true")
                        {
                            GreenscreenWallEnabled = "true";
                        }
                        else
                        {
                            GreenscreenWallEnabled = "false";
                        }

                        if (grab == 23)
                        {
                            return GreenscreenWallEnabled;
                        }
                    }

                    if (currentLine.Contains(ForceProfileEnabledIdentifier))
                    {
                        if (currentLine.Substring(ForceProfileEnabledIdentifier.Length, (currentLine.Length - ForceProfileEnabledIdentifier.Length)) == "true")
                        {
                            ForceProfileEnabled = "true";
                        }
                        else
                        {
                            ForceProfileEnabled = "false";
                        }
                        if (grab == 24)
                        {
                            return ForceProfileEnabled;
                        }
                    }
                    if (currentLine.Contains(FretlessModeEnabledIdentifier))
                    {
                        if (currentLine.Substring(FretlessModeEnabledIdentifier.Length, (currentLine.Length - FretlessModeEnabledIdentifier.Length)) == "true")
                        {
                            FretlessEnabled = "true";
                        }
                        else
                        {
                            FretlessEnabled = "false";
                        }

                        if (grab == 25)
                        {
                            return FretlessEnabled;
                        }
                    }
                    if (currentLine.Contains(RemoveInlaysIdentifier))
                    {
                        if (currentLine.Substring(RemoveInlaysIdentifier.Length, (currentLine.Length - RemoveInlaysIdentifier.Length)) == "true")
                        {
                            RemoveInlaysEnabled = "true";
                        }
                        else
                        {
                            RemoveInlaysEnabled = "false";
                        }

                        if (grab == 26)
                        {
                            return RemoveInlaysEnabled;
                        }
                    }
                    if (currentLine.Contains(ToggleLoftWhenIdentifier))
                    {
                        if (currentLine.Substring(ToggleLoftWhenIdentifier.Length, (currentLine.Length - ToggleLoftWhenIdentifier.Length)) == "manual")
                        {
                            ToggleLoftWhen = "manual";
                        }
                        if (currentLine.Substring(ToggleLoftWhenIdentifier.Length, (currentLine.Length - ToggleLoftWhenIdentifier.Length)) == "startup")
                        {
                            ToggleLoftWhen = "startup";
                        }
                        if (currentLine.Substring(ToggleLoftWhenIdentifier.Length, (currentLine.Length - ToggleLoftWhenIdentifier.Length)) == "song")
                        {
                            ToggleLoftWhen = "song";
                        }

                        if (grab == 27)
                        {
                            return ToggleLoftWhen;
                        }
                    }
                    if (currentLine.Contains(RemoveLaneMarkersIdentifier))
                    {
                        if (currentLine.Substring(RemoveLaneMarkersIdentifier.Length, (currentLine.Length - RemoveLaneMarkersIdentifier.Length)) == "true")
                        {
                            RemoveLaneMarkersEnabled = "true";
                        }
                        else
                        {
                            RemoveLaneMarkersEnabled = "false";
                        }

                        if (grab == 28)
                        {
                            return RemoveLaneMarkersEnabled;
                        }
                    }
                    if (currentLine.Contains(ToggleSkylineWhenIdentifier))
                    {
                        if(currentLine.Substring(ToggleSkylineWhenIdentifier.Length, (currentLine.Length - ToggleSkylineWhenIdentifier.Length)) == "song")
                        {
                            ToggleSkylineWhen = "song";
                        }
                        if (currentLine.Substring(ToggleSkylineWhenIdentifier.Length, (currentLine.Length - ToggleSkylineWhenIdentifier.Length)) == "startup")
                        {
                            ToggleSkylineWhen = "startup";
                        }

                        if (grab == 29)
                        {
                            return ToggleSkylineWhen;
                        }
                    }
                }

                // String Colors (Normal {N} & Colorblind {CB})
                {
                    // Normal Colors
                    {
                        if (currentLine.Contains(String0Color_N_Identifier))
                        {
                            String0Color_N = currentLine.Substring(String0Color_N_Identifier.Length, (currentLine.Length - String0Color_N_Identifier.Length));

                            if (grab == 30)
                            {
                                return String0Color_N;
                            }
                        }
                        if (currentLine.Contains(String1Color_N_Identifier))
                        {
                            String1Color_N = currentLine.Substring(String1Color_N_Identifier.Length, (currentLine.Length - String1Color_N_Identifier.Length));

                            if (grab == 31)
                            {
                                return String1Color_N;
                            }
                        }
                        if (currentLine.Contains(String2Color_N_Identifier))
                        {
                            String2Color_N = currentLine.Substring(String2Color_N_Identifier.Length, (currentLine.Length - String2Color_N_Identifier.Length));

                            if (grab == 32)
                            {
                                return String2Color_N;
                            }
                        }
                        if (currentLine.Contains(String3Color_N_Identifier))
                        {
                            String3Color_N = currentLine.Substring(String3Color_N_Identifier.Length, (currentLine.Length - String3Color_N_Identifier.Length));

                            if (grab == 33)
                            {
                                return String3Color_N;
                            }
                        }
                        if (currentLine.Contains(String4Color_N_Identifier))
                        {
                            String4Color_N = currentLine.Substring(String4Color_N_Identifier.Length, (currentLine.Length - String4Color_N_Identifier.Length));

                            if (grab == 34)
                            {
                                return String4Color_N;
                            }
                        }
                        if (currentLine.Contains(String5Color_N_Identifier))
                        {
                            String5Color_N = currentLine.Substring(String5Color_N_Identifier.Length, (currentLine.Length - String5Color_N_Identifier.Length));

                            if (grab == 35)
                            {
                                return String5Color_N;
                            }
                        }
                    }

                    // Color Blind Colors
                    {
                        if (currentLine.Contains(String0Color_CB_Identifier))
                        {
                            String0Color_CB = currentLine.Substring(String0Color_CB_Identifier.Length, (currentLine.Length - String0Color_CB_Identifier.Length));

                            if (grab == 36)
                            {
                                return String0Color_CB;
                            }
                        }
                        if (currentLine.Contains(String1Color_CB_Identifier))
                        {
                            String1Color_CB = currentLine.Substring(String1Color_CB_Identifier.Length, (currentLine.Length - String1Color_CB_Identifier.Length));

                            if (grab == 37)
                            {
                                return String1Color_CB;
                            }
                        }
                        if (currentLine.Contains(String2Color_CB_Identifier))
                        {
                            String2Color_CB = currentLine.Substring(String2Color_CB_Identifier.Length, (currentLine.Length - String2Color_CB_Identifier.Length));

                            if (grab == 38)
                            {
                                return String2Color_CB;
                            }
                        }
                        if (currentLine.Contains(String3Color_CB_Identifier))
                        {
                            String3Color_CB = currentLine.Substring(String3Color_CB_Identifier.Length, (currentLine.Length - String3Color_CB_Identifier.Length));

                            if (grab == 39)
                            {
                                return String3Color_CB;
                            }
                        }
                        if (currentLine.Contains(String4Color_CB_Identifier))
                        {
                            String4Color_CB = currentLine.Substring(String4Color_CB_Identifier.Length, (currentLine.Length - String4Color_CB_Identifier.Length));

                            if (grab == 40)
                            {
                                return String4Color_CB;
                            }
                        }
                        if (currentLine.Contains(String5Color_CB_Identifier))
                        {
                            String5Color_CB = currentLine.Substring(String5Color_CB_Identifier.Length, (currentLine.Length - String5Color_CB_Identifier.Length));

                            if (grab == 41)
                            {
                                return String5Color_CB;
                            }
                        }
                    }
                    
                }

                // Mod Settings
                {
                    if (currentLine.Contains(ExtendedRangeTuningIdentifier))
                    {
                        ExtendedRangeTuning = currentLine.Substring(ExtendedRangeTuningIdentifier.Length, (currentLine.Length - ExtendedRangeTuningIdentifier.Length));

                        if (grab == 19)
                        {
                            return ExtendedRangeTuning;
                        }
                    }
                    if (currentLine.Contains(CheckForNewSongIntervalIdentifier))
                    {
                        CheckForNewSongInterval = currentLine.Substring(CheckForNewSongIntervalIdentifier.Length, (currentLine.Length - CheckForNewSongIntervalIdentifier.Length));

                        if (grab == 42)
                        {
                            return CheckForNewSongInterval;
                        }
                    }
                    
                }
            }
            return "";
        }

            public static string SavedRocksmithLocation()
            {
                foreach (string currentLine in File.ReadLines(@WriteSettings.guiSettings))
                {
                    if (currentLine.Contains(RocksmithInstallLocationIdentifier))
                    {
                        RocksmithInstallLocation = currentLine.Substring(RocksmithInstallLocationIdentifier.Length, (currentLine.Length - RocksmithInstallLocationIdentifier.Length));
                        return RocksmithInstallLocation;
                    }
                }
                return "";
            }
        }
    }