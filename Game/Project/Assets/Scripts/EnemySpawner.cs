using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] _enemies;
    GameObject[] Enemies { get { return _enemies; } set { _enemies = value; } }

    [SerializeField]
    SpawnRound spawnRound;

    void Start()
    {
        StartWave();
    }

    void StartWave()
    {
        StartCoroutine(spawnRound.StartRound());
    }
}
