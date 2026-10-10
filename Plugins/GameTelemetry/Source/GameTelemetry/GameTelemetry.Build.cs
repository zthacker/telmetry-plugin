using UnrealBuildTool;

public class GameTelemetry : ModuleRules
{
	public GameTelemetry(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// M0 needs only Core (IModuleInterface, UE_LOG). Add modules as milestones need them:
		// CoreUObject and Engine for the subsystem, TraceLog for the channel, HTTP for sinks.
		PublicDependencyModuleNames.AddRange(new string[] { "Core" });
	}
}
