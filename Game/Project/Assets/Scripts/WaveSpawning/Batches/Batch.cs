using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BatchData", menuName = "EnemyWaves/Batch", order = 0)]
public class Batch : ScriptableObject
{
    [SerializeField]
    GameObject enemyToSpawn;
    public GameObject EnemyToSpawn { get { return enemyToSpawn; } set { enemyToSpawn = value; } }

    [SerializeField]
    int numEnemiesToSpawn;
    public int NumEnemiesToSpawn { get { return numEnemiesToSpawn; } set { numEnemiesToSpawn = value; } }

    [SerializeField]
    float waitTimeBetweenEnemies;
    public float WaitTimeBetweenEnemies { get { return waitTimeBetweenEnemies; } set { waitTimeBetweenEnemies = value; } }

    public IEnumerator SpawnBatch()
    {
        Debug.Log("Spawning enemies...");
        for (int i = 0; i < NumEnemiesToSpawn; i++)
        {
            Instantiate(EnemyToSpawn, new Vector2(-50, 20), Quaternion.identity);
            yield return new WaitForSeconds(WaitTimeBetweenEnemies);
        }
    }
}
