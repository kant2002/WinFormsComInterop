WinForms hosted in DLL
======================

This sample show steps required to put WinForms inside native DLL.

## How to build

Inside `x64 Native Tools Command Prompt for VS 2022` command line run following commands
```
dotnet publish -r win-x64 --self-contained
cl .\loader.c /Z7
```

after that you can run `loader.exe` which will show form.
