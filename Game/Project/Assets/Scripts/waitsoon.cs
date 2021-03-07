using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitsoon : MonoBehaviour
{
    public float time;
    public GameObject Particles;
    public GameObject WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example2());
        StartCoroutine(Example3());

    }

    IEnumerator Example2()
    {
        yield return new WaitForSeconds(3.5f);
        Particles.SetActive(true);
    }
    IEnumerator Example3()
    {
        yield return new WaitForSecondsRealtime(5f);

        WinScreen.SetActive(true);
    }
}
