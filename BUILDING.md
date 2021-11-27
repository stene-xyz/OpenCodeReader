# Building OpenCodeReader

## Requirements
- Godot 3.4 (Mono) and its requirements

## Instructions
- Open Godot
- Click "Scan"
- Select the OpenCodeReader folder
- Select OpenCodeReader in the project list
- Click "Project", then "Export"
- Install export templates if needed
- Click "Export All", then "Release"

## Troubleshooting
### Exported binary crashes with a System.TypeInitializationException error
Copy the `GodotSharp/Mono/lib` folder from your Godot installation to your exported `data_OpenCodeReader/Mono` folder.
