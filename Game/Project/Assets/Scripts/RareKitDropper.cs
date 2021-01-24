using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareKitDropper : MonoBehaviour
{
    [SerializeField] GameObject mgKitPrefab;
    [SerializeField] GameObject spKitPrefab;
    [SerializeField] GameObject zpKitPrefab;

    private void OnDestroy()
    {
        int[] drops = new int[2]
            {
                Random.Range(-1, 4),
                Random.Range(0, 4)
            };

        for(int i = 0; i < drops.Length; i++)
        {
            if(drops[i] == 0)
            {
                continue;
            }

            if(drops[i] == 1)
            {
                Instantiate(mgKitPrefab, gameObject.transform.position, Quaternion.identity);
                continue;
            }

            if (drops[i] == 2)
            {
                Instantiate(spKitPrefab, gameObject.transform.position, Quaternion.identity);
                continue;
            }

            if (drops[i] == 3)
            {
                Instantiate(zpKitPrefab, gameObject.transform.position, Quaternion.identity);
                continue;
            }
        }
    }
}
