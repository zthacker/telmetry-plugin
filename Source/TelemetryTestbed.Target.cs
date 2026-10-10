using UnrealBuildTool;

public class TelemetryTestbedTarget : TargetRules
{
	public TelemetryTestbedTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("TelemetryTestbed");
	}
}
