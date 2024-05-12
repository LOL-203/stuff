#include <Windows.h>
#include <cstdint>
#include <thread>
#include <iostream>
#include "ESP.h"
#include "memory.h"


DWORD WINAPI terminal(HMODULE hModule)
{
	AllocConsole();
	FILE * f;
	freopen_s(&f, "CONUT$", "w", stdout);

    std::cout << "Hello world";

    uintptr_t moduleBase = (uintptr_t)GetModuleHandle("Gameassembly.dll");
    uintptr_t DamageController_SetHealth = 0x9249344;

    //get player id
    
    
    if(GetAsyncKeyState(VK_DELETE))
    {
        FreeLibraryAndExitThread(hModule, 0);
    }
}


BOOL WINAPI DllMain(
    HINSTANCE hModule,  // handle to DLL module
    DWORD fdwReason,     // reason for calling function
    LPVOID lpvReserved)  // reserved
{
    // Perform actions based on the reason for calling.
    switch (fdwReason)
    {
    case DLL_PROCESS_ATTACH:
        // Initialize once for each new process.
        // Return FALSE to fail DLL load.
    case DLL_THREAD_ATTACH:
        CloseHandle(CreateThread(nullptr, 0, (LPTHREAD_START_ROUTINE)terminal, 0, 0, 0));
    case DLL_THREAD_DETACH:
        // Do thread-specific cleanup
    case DLL_PROCESS_DETACH:
        // Perform any necessary cleanup.
        break;
    }
}