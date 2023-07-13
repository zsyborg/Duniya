// Copyright Thesmo Labs

using UnrealBuildTool;
using System.Collections.Generic;

public class DuniyaDaariTarget : TargetRules
{
	public DuniyaDaariTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "DuniyaDaari" } );
	}
}
