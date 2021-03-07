using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "EnemyWaves/Wave", order = 0)]
public class Wave : ScriptableObject
{
    [SerializeField]
    Batch[] batchesToSpawn;
    public Batch[] BatchesToSpawn { get { return batchesToSpawn; } set { batchesToSpawn = value; } }

    [SerializeField]
    float delayBetweenBatches;
    public float DelayBetweenBatches { get { return delayBetweenBatches; } set { delayBetweenBatches = value; } }

    public IEnumerator SpawnWave()
    {
        MonoBehaviour spawner = GameObject.Find("WaveMonobehaviour").GetComponent<MonoBehaviour>();

        for(int i = 0; i < BatchesToSpawn.Length; i++)
        {
            spawner.StartCoroutine(BatchesToSpawn[i].SpawnBatch());
            yield return new WaitForSeconds(BatchesToSpawn[i].NumEnemiesToSpawn * BatchesToSpawn[i].WaitTimeBetweenEnemies + DelayBetweenBatches);
        }
    }
}
