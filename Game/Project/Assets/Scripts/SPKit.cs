using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            KitManager.sniperKits++;
            KitManager.spText.text = $"x {KitManager.sniperKits}";
            Destroy(gameObject);
        }
    }
}
