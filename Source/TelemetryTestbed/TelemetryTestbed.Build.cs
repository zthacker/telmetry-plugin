using UnrealBuildTool;

public class TelemetryTestbed : ModuleRules
{
	public TelemetryTestbed(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine" });
	}
}
