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