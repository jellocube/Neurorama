// Creative Commons Attribution-ShareAlike 4.0 International Public License

using UnrealBuildTool;
using System.Collections.Generic;

public class NeuroramaPreAlphaEditorTarget : TargetRules
{
	public NeuroramaPreAlphaEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "NeuroramaPreAlpha" } );
	}
}
