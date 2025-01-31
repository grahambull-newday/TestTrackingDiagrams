﻿using LightBDD.Core.ExecutionContext;

namespace TestTrackingDiagrams.LightBDD.XUnit;

public static class TrackingDiagramOverride
{
    public static void StartOverrideSummary(string plantUml)
    {
        DefaultTrackingDiagramOverride.StartOverrideSummary(GetTestId(), plantUml);
    }

    public static void EndOverrideSummary()
    {
        DefaultTrackingDiagramOverride.EndOverrideSummary(GetTestId());
    }

    public static void InsertPlantUml(string plantUml)
    {
        DefaultTrackingDiagramOverride.InsertPlantUml(GetTestId(), plantUml);
    }

    public static void InsertTestDelimiter(string testIdentifier)
    {
        DefaultTrackingDiagramOverride.InsertTestDelimiter(GetTestId(), testIdentifier);
    }

    private static string GetTestId() => ScenarioExecutionContext.CurrentScenario.Info.RuntimeId.ToString();
}