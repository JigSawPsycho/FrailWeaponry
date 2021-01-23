using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour
{
    // Start is called before the first frame update
    public static float SinGraphY(float x, float q)
    {
        return Mathf.Cos(x) + q;
    }
}
