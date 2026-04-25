// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShaderFinal1 : ModuleRules
{
	public ShaderFinal1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ShaderFinal1",
			"ShaderFinal1/Variant_Platforming",
			"ShaderFinal1/Variant_Platforming/Animation",
			"ShaderFinal1/Variant_Combat",
			"ShaderFinal1/Variant_Combat/AI",
			"ShaderFinal1/Variant_Combat/Animation",
			"ShaderFinal1/Variant_Combat/Gameplay",
			"ShaderFinal1/Variant_Combat/Interfaces",
			"ShaderFinal1/Variant_Combat/UI",
			"ShaderFinal1/Variant_SideScrolling",
			"ShaderFinal1/Variant_SideScrolling/AI",
			"ShaderFinal1/Variant_SideScrolling/Gameplay",
			"ShaderFinal1/Variant_SideScrolling/Interfaces",
			"ShaderFinal1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
