// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class IntroCpp03FpPc561 : ModuleRules
{
	public IntroCpp03FpPc561(ReadOnlyTargetRules Target) : base(Target)
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
			"IntroCpp03FpPc561",
			"IntroCpp03FpPc561/Variant_Horror",
			"IntroCpp03FpPc561/Variant_Horror/UI",
			"IntroCpp03FpPc561/Variant_Shooter",
			"IntroCpp03FpPc561/Variant_Shooter/AI",
			"IntroCpp03FpPc561/Variant_Shooter/UI",
			"IntroCpp03FpPc561/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
