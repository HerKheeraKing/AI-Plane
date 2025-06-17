using UnrealBuildTool;

public class LearningToDriveTarget : TargetRules
{
	public LearningToDriveTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("LearningToDrive");
	}
}
