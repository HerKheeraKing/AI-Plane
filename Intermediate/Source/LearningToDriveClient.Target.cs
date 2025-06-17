using UnrealBuildTool;

public class LearningToDriveClientTarget : TargetRules
{
	public LearningToDriveClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("LearningToDrive");
	}
}
