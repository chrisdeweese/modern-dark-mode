# modern-dark-mode
A simple API to check for light/dark mode on iOS and Android platforms.

------

### Setup for Unity 2021.3+

Import the `ModernProgramming` namespace into your project file to start using Modern Dark Mode.

------

### Get Device Theme

`DarkMode.CurrentMode == Mode.Light` - If true, the iOS or Android device is in light mode.

`DarkMode.CurrentMode == Mode.Dark` - If true, the iOS or Android device is in dark mode.

`DarkMode.CurrentMode == Mode.Unspecified` - If true, we cannot determine the device's theme.
