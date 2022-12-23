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
