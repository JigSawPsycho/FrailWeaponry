using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] _enemies;
    GameObject[] Enemies { get { return _enemies; } set { _enemies = value; } }

    [SerializeField]
    SpawnRound[] rounds;

    int currWave = 0;

    void Start()
    {
        currWave = 0;
        StartWave();
    }

    void StartWave()
    {
        StartCoroutine(rounds[currWave].StartRound());

        StartCoroutine(WaitForRoundToEnd());
    }

    IEnumerator WaitForRoundToEnd()
    {
        yield return new WaitUntil(() => GameObject.FindObjectsOfType<enemyHealth>().Length == 0);

        WaveFinished();
    }

    void WaveFinished()
    {
        Debug.Log("Wave finished.");
        currWave++;
        try
        {
            StartWave();
        } catch(System.IndexOutOfRangeException)
        {
            Debug.Log("Game finished!");
        }
    }
}
