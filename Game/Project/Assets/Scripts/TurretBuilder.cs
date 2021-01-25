using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBuilder : MonoBehaviour
{
    [SerializeField] GameObject MGTurretPrefab;
    [SerializeField] GameObject SPTurretPrefab;
    [SerializeField] GameObject ZPTurretPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerUtil.playerTurret = gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerUtil.playerTurret == gameObject)
        {
            PlayerUtil.playerTurret = null;
        }
    }
}
