TestBed for experimenting with WinForms and NativeAOT
=====================================================

Commands to test

	dotnet restore --packages packages -r win-x64 /p:Platform="Any CPU"
	dotnet build --no-restore /p:Platform="Any CPU"
	dotnet publish --no-build -r win-x64 WindowsFormsApp1/WindowsFormsApp1.csproj

Run from command line

	WindowsFormsApp1\bin\x64\Debug\net6.0-windows\win-x64\publish\WindowsFormsApp1.exe

If error like this appears `error CS0538: 'Accessibility.IAccessible' in explicit interface declaration is not an interface` -- Modify path to `Accessibility.dll` in the `WinFormsComInterop.csproj`