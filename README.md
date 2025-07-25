# CapCut-downgrade-tool

This is the README in en-us.

[português version](README-pt-br.md)

This is my first published project, sorry for any bugs

##

A simple C# editor for Windows Forms that allows you to downgrade the versions of CapCut projects, with automatic backup.

![Captura de tela 2025-07-08 075229](https://github.com/user-attachments/assets/d12d1f1a-dff8-4e3f-ae06-cef117a42422)

-⚠️ This application was created as a solution to the common problem:

- "This project was created by a newer version of CapCut. Update now"

- With CapCut-downgrade-tool, you can force the project to open in older versions of CapCut, safely and with automatic backup.

## Features

- Lists the installed versions of CapCut on the PC (only the first 3 numbers of the version)
- Lists the saved CapCut projects
- Downgrades the versions to the selected projects
- Automatically backs up the draft_content.json file before any changes
- Backups are stored in C:\Users%username%\AppData\Local\CapCut\User Data\Projects\com.lveditor.draft


## How to use

1. Select the desired CapCut version.
2. Select the project you want to modify.
3. Click “Apply Version” to downgrade.
4. If the caption style is changed, there is a backup.

## Important Notices

- CapCut automatically changes subtitle styles that are not compatible with older versions.
- This means that when downgrading to older versions of CapCut, some subtitles may lose fonts, colors or special effects that only exist in newer versions.
- The subtitle text **is not lost**, only the style can be modified.
- To minimize this problem, this editor creates automatic backups and allows you to restore the original styles after downgrading.
- We recommend using CapCut versions close to the original version of the project to avoid loss of style.
- If you open projects created in very recent versions of CapCut in very old versions, there may be a loss of visual quality in the subtitles due to incompatibility.
- example of what happens with open subtitles in an old CapCut,CapCut project version 6.5.0 when opened in version 4.0.0
  
 ![Captura de tela 2025-07-08 080025](https://github.com/user-attachments/assets/3b2ae8f1-e572-4670-b19f-72b0693cd77a)

## Requirements

- Windows with .NET Framework installed
- Visual Studio to open the project and compile (optional)

---
Contributions and suggestions are welcome!

---
**Author:** nakito448
