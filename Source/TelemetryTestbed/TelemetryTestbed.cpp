#include "Modules/ModuleManager.h"

// The testbed holds no telemetry code. This module exists so the project has
// build targets and can be compiled from the command line.
IMPLEMENT_PRIMARY_GAME_MODULE(FDefaultGameModuleImpl, TelemetryTestbed, "TelemetryTestbed");
