TestBed for experimenting with WinForms and NativeAOT
=====================================================

Test that normal CoreCLR works

	dotnet run --project samples\SampleWindowsForms\SampleWindowsForms.csproj
	dotnet run --project experiments\WpfTestBed\WpfTestBed.csproj
	dotnet run --project experiments\WinUITestBed\WinUITestBed\WinUITestBed.csproj
	dotnet run --project experiments\WinUIUWP\WinUIUWP.csproj

Test that NativeAOT works. Run commands in x64 developer tools.

	dotnet publish -r win-x64 samples\SampleWindowsForms\SampleWindowsForms.csproj
	"samples\SampleWindowsForms\bin\x64\Debug\net6.0-windows\win-x64\publish\SampleWindowsForms.exe"

	dotnet publish -r win-x64 experiments\WpfTestBed\WpfTestBed.csproj
	dotnet publish -r win-x64 experiments\WinUITestBed\WinUITestBed\WinUITestBed.csproj
	dotnet publish -r win-x64 experiments\WinUIUWP\WinUIUWP.csproj
