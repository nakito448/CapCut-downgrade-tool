A simple C# editor for Windows Forms that allows you to downgrade the versions of CapCut projects, with automatic backup.

![Captura de tela 2025-07-07 174112](https://github.com/user-attachments/assets/91ab4345-0b32-412e-beb0-885af72f3f00)

## Features

- Lists the installed versions of CapCut on the PC (only the first 3 numbers of the version)
- Lists the saved CapCut projects
- Downgrades the versions to the selected projects
- Automatically backs up the draft_content.json file before any changes
- Button to restore caption styles from the backup, avoiding loss of style after downgrading

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
- example of what happens with open subtitles in an old cap cut a cap cut project version 6.5.0 when opened in version 4.0.0
  
 ![Captura de tela 2025-07-08 080025](https://github.com/user-attachments/assets/3b2ae8f1-e572-4670-b19f-72b0693cd77a)

## Requirements

- Windows with .NET Framework installed
- Visual Studio to open the project and compile (optional)

---
Contributions and suggestions are welcome!

---
**Author:** nakito448
