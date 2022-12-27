# ❗❗❗ IMPORTANT ❗❗❗

I will not continue this project, because there is a similar project from Microsoft (Microsoft.Toolkit). The MS project offers the same (if not more) functionality. Therefore, from my point of view, it is no longer worthwhile to continue this project.

For more information see here [.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet) or here [nuget - CommunityToolki.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm/)

# ZimLabs.WpfBase.NetCore
 Class library for the ease use of MVVM in WPF applications

## Changelog

- v2.1.0 (Bugfix)
    - Fixed a bug which causes the RelayCommand to disable a button (wrong return value `false` instead of `true`)
- v2.0.0 (Breaking Change)
    - Changed the .NET from 5 to 6 because .NET 5 is not longer supported by Microsoft
    - Updated the class so that they are *nullable* (`nullable` parameter is set to `true`)
- v1.0.0
    - Initial release of the NetCore version of the *WpfBase*
