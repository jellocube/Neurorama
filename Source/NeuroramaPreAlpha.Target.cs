// Creative Commons Attribution-ShareAlike 4.0 International Public License

using UnrealBuildTool;
using System.Collections.Generic;

public class NeuroramaPreAlphaTarget : TargetRules
{
	public NeuroramaPreAlphaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "NeuroramaPreAlpha" } );
	}
}
