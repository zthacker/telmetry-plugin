#include "GameTelemetryModule.h"

DEFINE_LOG_CATEGORY(LogGameTelemetry);

void FGameTelemetryModule::StartupModule()
{
    UE_LOG(LogGameTelemetry, Log, TEXT("GameTelemetry module has started!"));
}

void FGameTelemetryModule::ShutdownModule()
{
    UE_LOG(LogGameTelemetry, Log, TEXT("GameTelemetry module is shutting down."));
}

IMPLEMENT_MODULE(FGameTelemetryModule, GameTelemetry)