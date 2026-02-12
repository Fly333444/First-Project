# First-Project

A Unity game project with test scripts, game scripts, and more.

## Project Overview

This is a Unity game project set up with a standard directory structure and example scripts to help you get started with game development.

## Unity Version

This project is configured for **Unity 2021.3.0f1** or later.

## Project Structure

```
First-Project/
├── Assets/
│   ├── Audio/          # Audio files (music, SFX, voice)
│   ├── Materials/      # Material files
│   ├── Prefabs/        # Reusable game object prefabs
│   ├── Scenes/         # Unity scene files
│   ├── Scripts/        # C# game scripts
│   └── Textures/       # Image files and textures
├── Packages/           # Package dependencies
├── ProjectSettings/    # Unity project settings
└── README.md
```

## Example Scripts

The project includes several example scripts to demonstrate Unity development:

### RotateObject.cs
A simple script that rotates a GameObject continuously. Useful for demonstrations and testing.

### PlayerController.cs
A basic player movement controller with:
- WASD/Arrow key movement
- Jump functionality
- Ground detection

### GameManager.cs
A singleton GameManager that provides:
- Pause/unpause functionality
- Score tracking
- Game state management

## Getting Started

1. **Clone this repository**
   ```bash
   git clone https://github.com/Fly333444/First-Project.git
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Add" or "Open"
   - Navigate to the project folder
   - Select the folder and click "Open"

3. **Create your first scene**
   - Go to File > New Scene
   - Add some GameObjects (GameObject > 3D Object)
   - Attach the example scripts to test them
   - Save the scene in Assets/Scenes/

4. **Start developing**
   - Write new scripts in Assets/Scripts/
   - Create prefabs for reusable objects
   - Import assets (textures, audio, models)
   - Build your game!

## Development Tips

- Use the Unity Editor to create and test your game
- Follow Unity naming conventions (PascalCase for public members)
- Keep your scripts focused and modular
- Test frequently in Play mode
- Use prefabs for objects you'll reuse
- Organize assets in appropriate folders

## Building the Game

1. Go to File > Build Settings
2. Add your scenes to the build
3. Select your target platform
4. Click "Build" or "Build and Run"

## Resources

- [Unity Documentation](https://docs.unity3d.com/)
- [Unity Learn](https://learn.unity.com/)
- [Unity Forums](https://forum.unity.com/)
- [Unity Asset Store](https://assetstore.unity.com/)

## License

This project is open source. Feel free to use it as a template for your own Unity projects.
