#define PathToLibrary "bin\\Debug\\net7.0-windows\\win-x64\\publish\\HostedWindowsForms.dll"
#define PathToLibrary2 "bin\\x64\\Debug\\net7.0-windows\\win-x64\\publish\\HostedWindowsForms.dll"

#include "windows.h"
#define symLoad GetProcAddress

#include <stdlib.h>
#include <stdio.h>

#ifndef F_OK
#define F_OK    0
#endif

void showMessageBox();

int main()
{
    // Check if the library file exists
    if (access(PathToLibrary, F_OK) == -1 && access(PathToLibrary2, F_OK) == -1)
    {
        puts("Couldn't find library at the specified path");
        return 0;
    }

    // Sum two integers
    showMessageBox();
}

void showMessageBox()
{
    // Call sum function defined in C# shared library
    HINSTANCE handle = LoadLibraryA(PathToLibrary);
    if (!handle)
    {
        handle = LoadLibraryA(PathToLibrary2);
    }

    if (!handle)
    {
        int errorCode = GetLastError();
        printf("Failed to load library at specified path. Error code: %d\n", errorCode);
        return;
    }

    typedef void(*ShowMessageBoxFuncType)();
    ShowMessageBoxFuncType ShowMessageBox = (ShowMessageBoxFuncType)symLoad(handle, "ShowMessageBox");

    ShowMessageBox();
}
