TestBed for experimenting with WinForms and NativeAOT
=====================================================

Commands to test

	dotnet restore --packages packages -r win-x64 /p:Platform="Any CPU"
	dotnet build --no-restore /p:Platform="Any CPU"

Test that normal CoreCLR works

	dotnet run --no-build --project WindowsFormsApp1/WindowsFormsApp1.csproj

Test that NativeAOT works.

	dotnet publish --no-build -r win-x64 WindowsFormsApp1/WindowsFormsApp1.csproj /p:Platform="Any CPU"
	""WindowsFormsApp1\bin\Any CPU\Debug\net6.0-windows\win-x64\publish\WindowsFormsApp1.exe"

I also create fake `bin\Any CPU` folders when requested by build, and copy Debug folder entirely. Maybe tweaks for solution would works better.
If error like this appears `error CS0538: 'Accessibility.IAccessible' in explicit interface declaration is not an interface` -- Modify path to `Accessibility.dll` in the `WinFormsComInterop.csproj`