using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class KitManager : MonoBehaviour
{
    public static int mgKits;
    public static int sniperKits;
    public static int zapperKits;

    private void Start()
    {
        mgKits = 0;
        sniperKits = 0;
        zapperKits = 0;
        GameObject[] pastKits = GameObject.FindGameObjectsWithTag("Kit");

        foreach(GameObject kit in pastKits)
        {
            Destroy(kit);
        }
    }
}
