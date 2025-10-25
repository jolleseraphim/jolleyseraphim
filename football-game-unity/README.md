# Football Game Project

## Overview
This project is a football game developed using Unity, inspired by the gameplay and graphics of DLS 2025. The game features realistic player movements, AI-controlled opponents, and an engaging user interface.

## Project Structure
- **Assets**: Contains all game assets including scenes, scripts, prefabs, models, animations, materials, shaders, audio, and UI layouts.
- **ProjectSettings**: Contains project-specific settings for Unity.
- **Packages**: Contains package dependencies for the project.
- **Docs**: Documentation files including design, art guidelines, and technical overview.
- **Tools**: Contains tools for exporting assets or data from the project.
- **.gitignore**: Specifies files and directories to be ignored by version control.
- **README.md**: Documentation and instructions for the project.
- **LICENSE**: Licensing information for the project.

## Getting Started
1. **Clone the Repository**: 
   Clone this repository to your local machine using Git.
   
   ```bash
   git clone <repository-url>
   ```

2. **Open in Unity**: 
   Open the project in Unity Hub and select the project folder.

3. **Build and Run**: 
   Use the Unity editor to build and run the game.

## Features
- **Game Management**: The `GameManager` class oversees the game state, including match start and end.
- **Match Control**: The `MatchController` class manages match logic, player actions, and scoring.
- **Player Control**: The `PlayerController` class handles player movements and actions.
- **AI Behavior**: The `AIManager` and `TacticalAI` classes control NPC behavior and decision-making.
- **Physics**: The `BallPhysics` class manages the football's physics interactions.
- **User Interface**: The `HUD` and `MenuManager` classes manage the game's UI elements.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.