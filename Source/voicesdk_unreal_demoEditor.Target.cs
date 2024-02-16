// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class voicesdk_unreal_demoEditorTarget : TargetRules
{
	public voicesdk_unreal_demoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "voicesdk_unreal_demo" } );
	}
}
