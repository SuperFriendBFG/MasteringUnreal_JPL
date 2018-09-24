// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MasteringUnreal_JPLEditorTarget : TargetRules
{
	public MasteringUnreal_JPLEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MasteringUnreal_JPL" } );
	}
}
