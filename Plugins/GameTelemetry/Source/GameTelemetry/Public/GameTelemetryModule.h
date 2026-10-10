#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

DECLARE_LOG_CATEGORY_EXTERN(LogGameTelemetry, Log, All);

class FGameTelemetryModule : public IModuleInterface
{

    public:
        /** IModuleInterface implementation */
        virtual void StartupModule() override;
        virtual void ShutdownModule() override;

};