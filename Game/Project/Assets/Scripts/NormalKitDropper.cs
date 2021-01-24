using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalKitDropper : MonoBehaviour
{
    [SerializeField] GameObject mgKitPrefab;
    [SerializeField] GameObject spKitPrefab;
    [SerializeField] GameObject zpKitPrefab;

    private void OnDestroy()
    {
        float dropChance = Random.Range(0, 1f);
        if (dropChance < 0.49f)
            return;
        else
        {
            if(dropChance < 0.65f)
            {
                Instantiate(mgKitPrefab, gameObject.transform.position, Quaternion.identity);
                return;
            }

            if(dropChance < 0.8f)
            {
                Instantiate(spKitPrefab, gameObject.transform.position, Quaternion.identity);
                return;
            }

            if(dropChance < 0.95f)
            {
                Instantiate(zpKitPrefab, gameObject.transform.position, Quaternion.identity);
                return;
            }

            return;
        }
    }
}
