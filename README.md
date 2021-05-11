TestBed for experimenting with WinForms and NativeAOT
=====================================================

Test that normal CoreCLR works

	dotnet run --project WindowsFormsApp1/WindowsFormsApp1.csproj
	dotnet run --project WpfTestBed\WpfTestBed.csproj

Test that NativeAOT works.

	dotnet publish -r win-x64 WindowsFormsApp1/WindowsFormsApp1.csproj /p:Platform="Any CPU"
	""WindowsFormsApp1\bin\Any CPU\Debug\net6.0-windows\win-x64\publish\WindowsFormsApp1.exe"

	dotnet publish -r win-x64 WpfTestBed\WpfTestBed.csproj /p:Platform="Any CPU"
