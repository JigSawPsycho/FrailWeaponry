using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtil : MonoBehaviour
{
    [SerializeField] GameObject MGTurretPrefab;
    [SerializeField] GameObject SPTurretPrefab;
    [SerializeField] GameObject ZPTurretPrefab;

    public static GameObject QPrompt;
    public static GameObject EPrompt;
    public static GameObject RPrompt;

    public static GameObject QWrench;
    public static GameObject EWrench;
    public static GameObject RWrench;

    public static GameObject MGPrompt;
    public static GameObject SPPrompt;
    public static GameObject ZPPrompt;

    public static GameObject playerTurret;

    public GameObject rocket;

    public static bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

        QPrompt = GameObject.Find("QPrompt");
        EPrompt = GameObject.Find("EPrompt");
        RPrompt = GameObject.Find("RPrompt");

        QWrench = GameObject.Find("QWrench");
        EWrench = GameObject.Find("EWrench");
        RWrench = GameObject.Find("RWrench");

        MGPrompt = GameObject.Find("MGPrompt");
        SPPrompt = GameObject.Find("SPPrompt");
        ZPPrompt = GameObject.Find("ZPPrompt");

        QPrompt.SetActive(false);
        EPrompt.SetActive(false);
        RPrompt.SetActive(false);

        QWrench.SetActive(false);
        EWrench.SetActive(false);
        RWrench.SetActive(false);

        MGPrompt.SetActive(false);
        SPPrompt.SetActive(false);
        ZPPrompt.SetActive(false);
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
