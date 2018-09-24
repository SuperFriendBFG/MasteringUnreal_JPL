// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MasteringUnreal_JPLTarget : TargetRules
{
	public MasteringUnreal_JPLTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MasteringUnreal_JPL" } );
	}
}
