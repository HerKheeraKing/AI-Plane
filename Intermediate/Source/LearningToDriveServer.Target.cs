using UnrealBuildTool;

public class LearningToDriveServerTarget : TargetRules
{
	public LearningToDriveServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("LearningToDrive");
	}
}
