using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WaveCreator : ScriptableWizard
{
    public Batch[] batches;

    public Wave[] waves;

    [MenuItem("MECustom/Create Round")]
    static void CreateRoundWizard()
    {
        DisplayWizard<WaveCreator>("Create a round of waves", "Create");
    }

    private void OnWizardCreate()
    {
        SpawnRound round = ScriptableObject.CreateInstance<SpawnRound>();
    }
}
