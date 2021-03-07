using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnRoundData", menuName = "EnemyWaves/SpawnRound", order = 0)]
public class SpawnRound : ScriptableObject
{
    [SerializeField]
    Wave[] waves;
    public Wave[] Waves { get { return waves; } set { waves = value; } }

    [SerializeField]
    float delayBetweenWaves;
    public float DelayBetweenWaves { get { return delayBetweenWaves; } set { delayBetweenWaves = value; } }

    public IEnumerator StartRound()
    {
        MonoBehaviour spawner = GameObject.Find("WaveMonobehaviour").GetComponent<MonoBehaviour>();

        for (int i = 0; i < waves.Length; i++)
        {
            spawner.StartCoroutine(waves[i].SpawnWave());
            yield return new WaitForSeconds(DelayBetweenWaves);
        }
    }
}
