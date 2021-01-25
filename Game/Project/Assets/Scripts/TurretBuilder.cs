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
            if(KitManager.mgKits > 0)
            {
                PlayerUtil.QPrompt.SetActive(true);
                PlayerUtil.MGPrompt.SetActive(true);
            }
            if (KitManager.sniperKits > 0)
            {
                PlayerUtil.EPrompt.SetActive(true);
                PlayerUtil.SPPrompt.SetActive(true);
            }
            if (KitManager.zapperKits > 0)
            {
                PlayerUtil.RPrompt.SetActive(true);
                PlayerUtil.ZPPrompt.SetActive(true);
            }
            PlayerUtil.playerTurret = gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && PlayerUtil.playerTurret == gameObject)
        {
            PlayerUtil.QPrompt.SetActive(false);
            PlayerUtil.EPrompt.SetActive(false);
            PlayerUtil.RPrompt.SetActive(false);

            PlayerUtil.MGPrompt.SetActive(false);
            PlayerUtil.SPPrompt.SetActive(false);
            PlayerUtil.ZPPrompt.SetActive(false);

            PlayerUtil.playerTurret = null;
        }
    }
}
