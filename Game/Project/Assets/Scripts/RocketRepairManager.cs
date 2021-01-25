using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketRepairManager : MonoBehaviour
{
    int mgKitsUsed;
    int spKitsUsed;
    int zpKitsUsed;

    public static Text MBPacks;
    public static Text MYPacks;
    public static Text MPPacks;

    public static bool onMissile = false;

    bool hasWon;

    // Start is called before the first frame update
    void Start()
    {
        mgKitsUsed = 0;
        spKitsUsed = 0;
        zpKitsUsed = 0;

        MBPacks = GameObject.Find("MBPacks").GetComponent<Text>();
        MYPacks = GameObject.Find("MYPacks").GetComponent<Text>();
        MPPacks = GameObject.Find("MPPacks").GetComponent<Text>();

        MYPacks.text = "x 150";
        MBPacks.text = "x 150";
        MPPacks.text = "x 150";

        hasWon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(onMissile)
        {
            //Show images for buttons
            if(Input.GetKeyDown(KeyCode.Q) && mgKitsUsed < 50)
            {
                KitManager.mgKits--;
                KitManager.mgText.text = $"x {KitManager.mgKits}";
                mgKitsUsed++;
                MYPacks.text = $"x {150 - mgKitsUsed}";
            }

            if (Input.GetKeyDown(KeyCode.E) && spKitsUsed < 50)
            {
                KitManager.sniperKits--;
                KitManager.spText.text = $"x {KitManager.sniperKits}";
                spKitsUsed++;
                MBPacks.text = $"x {150 - spKitsUsed}";
            }

            if (Input.GetKeyDown(KeyCode.R) && zpKitsUsed < 50)
            {
                KitManager.zapperKits--;
                KitManager.zpText.text = $"x {KitManager.zapperKits}";
                zpKitsUsed++;
                MPPacks.text = $"x {150 - zpKitsUsed}";
            }
        }

        if (zpKitsUsed + spKitsUsed + mgKitsUsed == 150 && hasWon == false)
        {
            //Win code here

            hasWon = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(KitManager.mgKits > 0 && mgKitsUsed < 50)
        {
            PlayerUtil.QWrench.SetActive(true);
            PlayerUtil.QPrompt.SetActive(true);
        }

        if (KitManager.sniperKits > 0 && spKitsUsed < 50)
        {
            PlayerUtil.EWrench.SetActive(true);
            PlayerUtil.EPrompt.SetActive(true);
        }

        if (KitManager.zapperKits > 0 && zpKitsUsed < 50)
        {
            PlayerUtil.RWrench.SetActive(true);
            PlayerUtil.RPrompt.SetActive(true);
        }
        
        
        
        onMissile = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerUtil.QPrompt.SetActive(false);
        PlayerUtil.EPrompt.SetActive(false);
        PlayerUtil.RPrompt.SetActive(false);

        PlayerUtil.QWrench.SetActive(false);
        PlayerUtil.EWrench.SetActive(false);
        PlayerUtil.RWrench.SetActive(false);
        onMissile = false;
    }
}
