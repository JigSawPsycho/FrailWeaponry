using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZPKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            KitManager.zapperKits++;
            KitManager.zpText.text = $"x {KitManager.zapperKits}";
            Destroy(gameObject);
        }
    }
}
