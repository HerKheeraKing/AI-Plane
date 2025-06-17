using UnrealBuildTool;

public class LearningToDriveEditorTarget : TargetRules
{
	public LearningToDriveEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("LearningToDrive");
	}
}
