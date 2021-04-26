TestBed for experimenting with WinForms and NativeAOT
=====================================================

Commands to test

	dotnet restore --packages packages
	dotnet build
	cd WindowsFormsApp1
	dotnet publish -r win-x64

If error like this appears `error CS0538: 'Accessibility.IAccessible' in explicit interface declaration is not an interface` -- Modify path to `Accessibility.dll` in the `WinFormsComInterop.csproj`