using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathSoon : MonoBehaviour
{
    public float wait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example2());


    }

    IEnumerator Example2()
    {

        yield return new WaitForSeconds(wait);


        Destroy(gameObject);
    }
}
