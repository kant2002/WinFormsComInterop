ComWrappers required to run NativeAOT and WinForms
=====================================================

This repository has ComWrappers implementation for WinForms.
In additional to that, it allow use WinForms and NativeAOT and R2R with trimming together.

## Getting started

Just add `WinFormsComInterop` to your project.

	dotnet add package WinFormsComInterop

Then to your Program.cs add following line

	ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);

And modify project file to enable NativeAOT
```
<PublishAot>true</PublishAot>
<_SuppressWinFormsTrimError>true</_SuppressWinFormsTrimError>
```

If you application will works with this ComWrappers implementation, then most likely it would work with NativeAOT.

If you are using WebView2 using `Microsoft.Web.WebView2.Core` package, then use 

	ComWrappers.RegisterForMarshalling(WinFormsComInterop.WebView2.WebView2ComWrapper.Instance);

Also 
1. Add RD.xml file from https://github.com/kant2002/RdXmlLibrary/blob/main/Microsoft.AspNetCore.Components.Web.rd.xml to project 
2. Add `<RdXmlFile Include="Microsoft.AspNetCore.Components.Web.rd.xml" />` to project file
3. Make sure that RootComponets are added to you app-specific rd.xml
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Directives>
  <Application>
    <Assembly Name="YourAppAssembly" Dynamic="Required All">
      <Type Name="YourAppAssembly.YourRootComponent" Dynamic="Required All" />
    </Assembly>
  </Application>
</Directives>
```

## Testing technology

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

	dotnet publish -r win-x64 experiments\WpfTestBed\WpfTestBed.csproj -p:GenerateWPF=true

 blocked by https://github.com/kant2002/WinFormsComInterop/issues/30

 ### WinUI

	dotnet publish -r win10-x64 experiments\WinUITestBed\WinUITestBed\WinUITestBed.csproj

### Classic UWP project

	dotnet publish -r win-x64 experiments\WinUIUWP\WinUIUWP.csproj

does not working due to this error 
```
experiments\WinUIUWP\WinUIUWP.csproj : error MSB4057: The target "Restore" does not exist in the project.
```

## For brave souls

Mostly notes for me, but maybe somebody would like to hack.

Build (NativeAOT)[https://github.com/dotnet/runtimelab/tree/feature/NativeAOT].

Modify nuget.config
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <!--To inherit the global NuGet package sources remove the <clear/> line below -->
    <clear />
    <!--Locally built version of NativeAOT -->
    <add key="ILC" value="c:\runtimelab\artifacts\packages\Debug\Shipping\" />
    <!--To use daily builds of runtime -->
    <add key="dotnet6" value="https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet6/nuget/v3/index.json" />
  </packageSources>
</configuration>
```

Restore packages to local folder to not pollute global Nuget cache. You will build NativAOT a lot.

	dotnet restore -r win-x64 --packages packages

Then publish applications using regular workflow described above.


# Additional reading

Design of future stubs in Runtime
- https://github.com/dotnet/runtimelab/blob/feature/DllImportGenerator/designs/Pipeline.md#stub-code-generation
