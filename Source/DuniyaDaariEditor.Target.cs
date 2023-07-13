// Copyright Thesmo Labs

using UnrealBuildTool;
using System.Collections.Generic;

public class DuniyaDaariEditorTarget : TargetRules
{
	public DuniyaDaariEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "DuniyaDaari" } );
	}
}
