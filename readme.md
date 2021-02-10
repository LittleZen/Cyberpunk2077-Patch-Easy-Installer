# Cyberpunk 2077 | Easy Patcher

This software allows you to easily install all the patches from [CyberEngineTweaks](https://bit.ly/384rMEx), created by yamashi.
For any problems, or for more information, check the main repository (by yamashi). 😊

-----------
![Demo](https://i.imgur.com/W7UpaxI.png)


[DOWNLOAD](https://bit.ly/384rLQZ) | [MAIN REPOSITORY](https://bit.ly/384rMEx) | [ISSUES](https://bit.ly/34cbtUX)

-----------

## Index
- [Guide](#guide)
- [About](#about)
- [Contributors](#contributors)
- [Previous Versions](#previous-versions)
- [Changelog](#changelog)


-----------
## Guide

1) Download the .exe file
2) Open it and extract the files where you want.
3) Open `CP2077 - EasyPatcher.exe` from the folder extracted
4) If you use Steam or GOG, just click "Find Steam Path" or "Find GOG Path" (patch will be automatically installed)
5) If you want manually select it (or if you use EpicGames), just click on "Select Path to Cyberpunk 2077 Main Directory"  and select the main folder of "Cyberpunk 2077" (not the x64 folder! The main directory!)
6) Enjoy, and check yamashi's main page, he's the true hero!

-----------

## About
Type | Description
--- | ---
`Language` | *C# (patch in c++)*
`Installer Developer` | *LittleZen*
`Patch Developer` | *[yamashi + others](https://github.com/yamashi/CyberEngineTweaks)*
`Patcher Base Version` | *1.0*

-----------

# Contributors

- [x] [JayVee732](https://github.com/JayVee732)
- [x] [Saibamen](https://github.com/Saibamen)
- [x] [kevinf100](https://github.com/kevinf100)
- [x] [Yamashi](https://github.com/yamashi)

-----------

## Changelog

### Version 1.0 [15/12/2020]

- [x] Released Easy Patcher v1.0
- [x] Released yamashi patch v0.7.0

-----------

### Version 2.0 [16/12/2020]

- [x] Released Easy Patcher v2.0
- [x] Released yamashi patch v0.7.2
- [x] New HUD (Now you can directly manage the settings through the tool)
- [x] Tool will now automatically detect (after the first time) the path of CP2077, and won't ask to re-insert the path
- [x] You can now directly open the json file (for manually manage the settings or for check it)
- [x] "About" now correctly redirect all to this thread
- [x] Some minor visual effects added
- [x] Now requires Administrator Privilege
- [x] Icons updated
- [x] Code Cleared

-----------

### Version 2.2 [17/12/2020]

- [x] Resolved a bug where the game didn't start properly after the installation of the patch
- [x] `Uninstall` System Added (now you can easy install/unistall the patches)
- [x] `Check Update` System added (will automatically install the lastest patch available)
- [x] ToolTips added. Just move the cursor over the settings, for check what they do
- [x] Update system now correctly remove the zip files downloaded, after the update
- [x] Released the option `Remove Pedestrians` (yamashi)
- [x] Released the option `Disable Antialiasing` (yamashi)
- [x] Added the `Memory Pool` section for correctly manage the memory pool (CPU/GPU) (yamashi)
- [x] Released the `Async Compute` features (yamashi)
- [x] Released the `Skip Start menù` features (yamashi)
- [x] Installation method will now install the latest patch available
- [x] Changed Memory Pool Input (NumbericUpDown added)
- [x] Huge code CleanUp + Error Handling
- [x] .gitignore updated
- [x] Autofind Steam path added
- [x] Autofind GOG path added
- [x] Minor changes and bug fix

-----------

### Version 2.5 [18/12/2020]

- [x] Added support for the console command (yamashi)
- [x] Changed button text, now they are more clear
- [x] Changed Messagebox, now they are more clear
- [x] MaximizeBox option disabled
- [x] Code clean up + minor improvements
- [x] "Dump Game Option" features by yamashi added
- [x] New ToolTips

-----------

### Version 2.7 [19/12/2020]

- [x] Now the tool will automatically check for EasyPatcher update, and notify it!

-----------

### Version 2.8 [20/12/2020]

- [x] Fixed an issue that doesn't allow mod installation
- [x] Resolved a bug where save the settings before install the patch may start unexpected crash
- [x] Resolved a bug where the Console Key was not being set on the initial installation of the mods
- [x] New ToolTips added
- [x] HUD changed due to new options available
- [x] Released the `Dump Game Option` option (yamashi)
- [x] Released the `Debugger` option (yamashi)
- [x] Released the `Console` option (yamashi)
- [x] Released the `Disable Vignette` option (yamashi)
- [x] Released the `Disable Boundary Teleport` option (yamashi)
- [x] Released the `Disable Intro Movies` option (yamashi)
- [x] Update system-logic changed
- [x] Console key checkbox, now correctly disable the console input forms (if disabled)
- [x] Console key now correctly work (@JayVee732)
- [x] Error messagebox improved for correctly find future bugs
- [x] Code cleaned + minor bug fixes

-----------

### Version 3.1 [21/12/2020]

- [x] Messagebox error improved (now correctly show the exception. This may be useful for detect future bugs)
- [x] Uninstall system now correctly delete all files (uninstall system now correctly show the tracedebug output)
- [x] Json indentation fixed
- [x] Uninstall and reinstall will now correctly load the default settings 
- [x] Settings options are now available only after the installation of the patch
- [x] Use Tilde Key: updated the initial value to use the Keys enum
- [x] Refactored Return Functions: Shorted functions for returning registry values.
- [x] Yamashi's repository updated (all links are now correctly redirected)
- [x] Prevent "empty" Yes/No MsgBox and Exception after clicking Yes in autodetect GOG mode
- [x] Code cleaned up

-----------

### Version 3.2 [06/01/2021]

- [x] Correctly redirect the download of latest yamashi's patch, now EasyPatcher correctly work!
- [x] Download/Install patch will now correctly delete the zip archive after installation
- [x] Uninstall/Download System now correctly work (and delete the correct files)
- [x] Code Cleaned-up + new comments

-----------

### Version 3.5 [10/02/2021]

- [x] Fixed a bug which cause the installation fail
- [x] Improved and fixed the uninstall method
- [x] Clean downloadPath folder to prevent Exception while trying to extract already exists files
- [x] Code optimization, and minors bug fixies

-----------

## LICENSE AND USE

- [x] Install the patch, download the source or the installer will result as "license and use" accepted
- [x] I do not take any responsibility for any problems resulting from this software.
