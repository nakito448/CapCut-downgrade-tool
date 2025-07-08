# CapCut-downgrade-tool

This is my first published project, sorry for any bugs

##

A simple C# editor for Windows Forms that allows you to downgrade the versions of CapCut projects, with automatic backup.

![Captura de tela 2025-07-08 075229](https://github.com/user-attachments/assets/5379dc45-d1aa-4cd7-8aa0-7987827f72b5)


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

## Requirements

- Windows with .NET Framework installed
- Visual Studio to open the project and compile (optional)

---
Contributions and suggestions are welcome!

---
**Author:** nakito448
