using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBotsScript : MonoBehaviour
{
    public GameObject explosion;

    public float health = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( health <= 0f)
        {
            Debug.Log("u ded Lol");

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(explosion, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
        health = health - 1;
    }
}
