// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class LogitechWheelPlugin : ModuleRules
{
	public LogitechWheelPlugin(TargetInfo Target)
	{
		
		PublicIncludePaths.AddRange(
			new string[] {
				"LogitechWheelPlugin/Public"
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"LogitechWheelPlugin/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
                "Core",
                "InputCore",
                "InputDevice",

				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        string BaseDirectory = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
        string LogitechDirectory = Path.Combine(BaseDirectory, "Logitech", "lib", Target.Platform.ToString());
        string[] LibraryNames = { "LogitechSteeringWheelLib" };

        PublicLibraryPaths.Add(LogitechDirectory);
        foreach (string LibraryName in LibraryNames)
        {
            PublicAdditionalLibraries.Add(LibraryName + ".lib");
        }
    }
}
