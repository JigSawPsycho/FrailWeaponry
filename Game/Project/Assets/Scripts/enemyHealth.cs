using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public GameObject explosion;
    public float EnemyHealth = 10f;
    

    void Update()
    {

        if (EnemyHealth <= 0f)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void GetHit(float _damage)
    {
        EnemyHealth -= _damage;
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
