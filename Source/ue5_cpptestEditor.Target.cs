// Copyright Epic Games, Inc.

using UnrealBuildTool;
using System.Collections.Generic;

public class ue5_cpptestEditorTarget : TargetRules
{
    public ue5_cpptestEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
        ExtraModuleNames.AddRange(new List<string> { "ue5_cpptest" });
    }
}
