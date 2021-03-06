#include "DisableControllers.hpp"

LPVOID* DirectInputPointer = NULL;

void XInput() {
	// 0x01c5970e function to remove XInput1_3 devices.
	*(HMODULE*)0x0135de18 = 0x0; // XInput Library (Tell the game XInput doesn't need to be loaded anymore)
	*(FARPROC*)0x0135de28 = 0x0; // XInput Enable (to false)
}

void _declspec(naked) hook_DirectInput() {
	__asm {
		mov DirectInputPointer, esi
		push 0x800
		jmp[Offsets::hookBackAddr_DirectInput8]
	}
}

void DirectInput() {
	MemUtil::PlaceHook((void*)Offsets::hookAddr_DirectInput8, hook_DirectInput, 5);
}

void DisableControllers::DisableControllers() {
	std::cout << "Disabling Controllers..." << std::endl;
	XInput();
	DirectInput();
	std::cout << "DI8-Pointer: " << DirectInputPointer << std::endl;
}