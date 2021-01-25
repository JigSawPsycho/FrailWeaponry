using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtil : MonoBehaviour
{
    [SerializeField] GameObject MGTurretPrefab;
    [SerializeField] GameObject SPTurretPrefab;
    [SerializeField] GameObject ZPTurretPrefab;

    public static GameObject playerTurret;

    public static bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (playerTurret != null)
            {
                if (KitManager.mgKits > 0)
                {
                    //Show mgbuildbutton
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        Instantiate(MGTurretPrefab, playerTurret.transform.position, Quaternion.identity);
                        KitManager.mgKits--;
                        KitManager.mgText.text = $"x {KitManager.mgKits}";
                        Destroy(playerTurret);
                    }
                }

                if (KitManager.sniperKits > 0)
                {
                    //Show spbuildbutton
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Instantiate(SPTurretPrefab, playerTurret.transform.position, Quaternion.identity);
                        KitManager.sniperKits--;
                        KitManager.spText.text = $"x {KitManager.sniperKits}";
                        Destroy(playerTurret);
                    }
                }

                if (KitManager.zapperKits > 0)
                {
                    //Show zpbuildbutton
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Instantiate(ZPTurretPrefab, playerTurret.transform.position, Quaternion.identity);
                        KitManager.zapperKits--;
                        KitManager.zpText.text = $"x {KitManager.zapperKits}";
                        Destroy(playerTurret);
                    }
                }
            }
        }
    }
}
