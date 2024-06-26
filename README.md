# AmongUsReplayInWindow -Polybius
![license MIT](https://img.shields.io/badge/license-MIT-green)
![Downloads num](https://img.shields.io/github/downloads/sawa90/AmongUsReplayInWindow/total)  
![screenshot](https://github.com/sawa90/AmongUsReplayInWindow/blob/images/scrnshot3.png)

This project add a simple replay feature to Among Us (Steam version). The replay will appear in the game window when you return to the lobby after the game.
In the replay, you can see everyone's location, who killed them and when, the progress of the task, voting result, if they are in the vent, and sabotage.  
It can also output text logs, including chat logs.  

## Requirement
[.NET 5 Desktop Runtime x86](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.3-windows-x86-installer)  
[Visual C++ Redistributable for Visual Studio 2015 x86](https://www.microsoft.com/en-us/download/details.aspx?id=48145)  
## Usage
- Download zip from [latest release](https://github.com/sawa90/AmongUsReplayInWindow/releases/latest) page and unpack it
- Run Among Us
- Run `AmongUsReplayInWindow.exe`
- Click "Get Among Us Window" button
- Play game

When the game is over, a replay of the last game will be displayed in the game window.  
Use the control keys to open and close the replay, and drag the track bar or use the arrow keys to control it.  
The replays will be saved in "replay" folder under the folder containing the exe, and you can also view them by clicking the "Open" button to open the file.  

## Demo
[Youtube](https://youtu.be/qMS7B8juyDo)

## Note
- Who killed a crew is determined by the imposter who was closest to the crew, so it is possible to make a mistake.
- The winner may be displayed incorrectly when the game is decided by disconnect.
- The map and icon images can be replaced by saving them in the map and icon folders under the same name. For map images, please make sure that the position of the map and the aspect ratio of the image match the original file.
- If it doesn't work, please report an error. I would appreciate it if you could download the version with "withConsole" from [latest release](https://github.com/sawa90/AmongUsReplayInWindow/releases/latest) and post the output of the console window. If you don't see any errors in the output, please feel free to let me know.

## License
The source code is under the MIT license, but the image files are not, and must be handled according to the AMONG US policy.

## References
[amonguscapture](https://github.com/automuteus/amonguscapture) by Denver Quane  
[among-us-replay-mod](https://github.com/Smertig/among-us-replay-mod) by Smertig  
[AmongUsMemory](https://github.com/shlifedev/AmongUsMemory) by shlifedev  
  
  
  
##
This tool is not affiliated with Among Us or Innersloth LLC, and the content contained therein is not endorsed or otherwise sponsored by Innersloth LLC. Portions of the materials contained herein are property of Innersloth LLC. © Innersloth LLC.
