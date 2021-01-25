using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGKit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            KitManager.mgKits++;
            KitManager.mgText.text = $"x {KitManager.mgKits}";
            Destroy(gameObject);
        }
    }
}
