# AlfredAutoClick

AlfredAutoClick is a lightweight and customizable auto-clicker for Windows.  
It allows you to simulate automatic mouse clicks with precise control over timing, click behavior, and activation hotkeys.

## Features

- ✅ Choose between **Left**, **Right**, **Middle**, or **Other** mouse buttons  
- 🔁 Support for **Multi-Click** or **Hold Down** modes  
- ⏱️ Adjustable delay between clicks and between click bursts  
- 🔢 Optional "Stop after N bursts" feature  
- 💾 Settings are automatically saved in your `AppData` folder  

## How to Use

1. Launch the application.
2. Customize your click settings:
   - Mouse button
   - Click mode (multi-click or hold)
   - Delay between clicks and bursts
   - Hotkey for starting/stopping the clicker
3. Press the **Save Config** button to store your settings.
4. Press your defined hotkey anywhere to toggle the clicker on or off.

## Configuration

All settings are saved to: %AppData%\AlfredAutoClick\config.json

This file is auto-created and updated each time you save your configuration.

## Requirements

- Windows 10 / 11
- .NET Framework 4.8 or higher  
- Administrator rights may be needed to simulate clicks in some programs or games

## Roadmap

- [ ] Auto-start with Windows  
- [ ] Smart click zones  
- [ ] Game-specific profiles  
- [ ] Statistics panel

## License

This project is open-source and available under the MIT License.