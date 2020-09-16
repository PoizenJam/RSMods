#pragma once
#include "windows.h"
#include <vector>

#include "MemUtil.hpp"

namespace Offsets {
	extern uintptr_t baseHandle; // Beginning of Rocksmith
	extern uintptr_t baseEnd; // End of Rocksmith

	// Loft Settings
	extern uintptr_t ptr_loft;
	extern std::vector<unsigned int> ptr_loft_nearOffsets;
	extern std::vector<unsigned int> ptr_loft_farOffsets;

	// Current Tuning
	extern uintptr_t ptr_tuning;
	extern std::vector<unsigned int> ptr_tuningOffsets;

	// Current Note (Midi value: https://djip.co/w/wp-content/uploads/drupal/blog/logic-midi-note-numbers.png | 0 - 96 are used in Rocksmith).
	extern uintptr_t ptr_guitarSpeak;
	extern std::vector<unsigned int> ptr_guitarSpeakOffets;

	// Wwise Audio Volume
	extern uintptr_t func_SetRTPCValue;
	extern uintptr_t func_GetRTPCValue;

	// Mixer Volumes
	extern uintptr_t ptr_songVolume;
	extern std::vector<unsigned int> ptr_songVolumeOffsets;
	extern uintptr_t ptr_mixerVolumeBase;
	extern std::vector<unsigned int> ptr_playerOneGuitarOffsets;
	extern std::vector<unsigned int> ptr_playerOneBassOffsets;
	extern std::vector<unsigned int> ptr_playerTwoGuitarOffsets;
	extern std::vector<unsigned int> ptr_playerTwoBassOffsets;
	extern std::vector<unsigned int> ptr_micOffsets;
	extern std::vector<unsigned int> ptr_voOffsets;
	extern std::vector<unsigned int> ptr_sfxOffsets;

	// Force Enumeration
	extern uintptr_t hookBackAddr_ForceEnumeration, hookBackAddr_Enumeration;
	extern uintptr_t func_ForceEnumeration;
	extern uintptr_t ptr_enumerateService;
	extern std::vector<unsigned int> ptr_enumerateServiceOffsets;

	// Custom Song Lists
	extern uintptr_t hookBackAddr_FakeTitles, hookBackAddr_CustomNames, hookBackAddr_missingLocalization;
	extern uintptr_t hookAddr_ModifyLocalized;
	extern uintptr_t hookAddr_ModifyCleanString;
	extern uintptr_t hookAddr_MissingLocalization;
	extern uintptr_t func_getStringFromCSV;
	extern uintptr_t func_getLocalizedString;
	extern uintptr_t func_appendString; //for reference purposes

	//D3D Stuff
	extern const char* d3dDevice_Pattern;
	extern uint32_t d3dDevice_SearchLen;
	extern char* d3dDevice_Mask;

	// cDLC Stuff :P
	extern uintptr_t cdlcCheckdwAdr;
	extern uintptr_t cdlcCheckSearchLen;
	extern uint8_t* cdlcCheckAdr;
	extern const char* sig_CDLCCheck;
	extern char* sig_CDLCCheckMask;
	extern const char* patch_CDLCCheck;
	extern uintptr_t patch_addedSpaces;
	extern uintptr_t patch_addedNumbers;
	extern uintptr_t patch_sprintfArg;
	extern const char* patch_ListSpaces;
	extern const char* patch_ListNumbers;
	extern const char* patch_SprintfArgs;
	void Initialize();

	// Current Menu
	// extern uintptr_t ptr_currentMenu;
	// extern std::vector<unsigned int> ptr_currentMenuOffsets; // Old menu check, decided it loved to not work on some builds
	extern uintptr_t ptr_currentMenu; // https://media.discordapp.net/attachments/711633334983196756/744071651498655814/unknown.png, the game uses this one, so we may as well
	extern std::vector<unsigned int> ptr_currentMenuOffsets; // But the offsets stay the same, hurray!
	extern std::vector<unsigned int> ptr_preMainMenuOffsets;

	// Timer
	extern uintptr_t ptr_timer;
	extern std::vector<unsigned int> ptr_timerOffsets;

	// Colorblind Mode
	extern uintptr_t ptr_colorBlindMode;
	extern std::vector<unsigned int> ptr_colorBlindModeOffsets;

	// Misc Mods
	extern uintptr_t ptr_stringColor;
	extern uintptr_t ptr_drunkShit; //search for float 0.333333, seems like it's static
};