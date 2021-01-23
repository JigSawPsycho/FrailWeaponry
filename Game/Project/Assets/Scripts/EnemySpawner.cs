using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, 1f);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, this.gameObject.transform.position, Quaternion.identity, this.transform);
    }
}
