TestBed for experimenting with WinForms and NativeAOT
=====================================================

Test that normal CoreCLR works

	dotnet run --project samples\SampleWindowsForms\SampleWindowsForms.csproj
	dotnet run --project experiments\WpfTestBed\WpfTestBed.csproj
	dotnet run --project experiments\WinUITestBed\WinUITestBed\WinUITestBed.csproj
	dotnet run --project experiments\WinUIUWP\WinUIUWP.csproj

## NativeAOT
Test that NativeAOT works. 
Run commands in x64 developer tools.

### WinForms

	dotnet publish -r win-x64 samples\SampleWindowsForms\SampleWindowsForms.csproj
	"samples\SampleWindowsForms\bin\x64\Debug\net6.0-windows\win-x64\publish\SampleWindowsForms.exe"

Below are experimental projects. They are need additional work.

### WPF

	dotnet publish -r win-x64 experiments\WpfTestBed\WpfTestBed.csproj

 blocked by https://github.com/dotnet/runtimelab/issues/1106

 ### WinUI

	dotnet publish -r win10-x64 experiments\WinUITestBed\WinUITestBed\WinUITestBed.csproj

### Classic UWP project

	dotnet publish -r win-x64 experiments\WinUIUWP\WinUIUWP.csproj

does not working due to this error 
```
experiments\WinUIUWP\WinUIUWP.csproj : error MSB4057: The target "Restore" does not exist in the project.
```