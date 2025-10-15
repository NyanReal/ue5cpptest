// Copyright Epic Games, Inc.

using UnrealBuildTool;
using System.Collections.Generic;

public class ue5_cpptestTarget : TargetRules
{
    public ue5_cpptestTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
        ExtraModuleNames.AddRange(new List<string> { "ue5_cpptest" });
    }
}
