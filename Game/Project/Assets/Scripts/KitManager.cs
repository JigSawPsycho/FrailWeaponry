using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class KitManager : MonoBehaviour
{
    public static int mgKits;
    public static int sniperKits;
    public static int zapperKits;

    public static Text mgText;
    public static Text spText;
    public static Text zpText;

    private void Start()
    {
        mgKits = 1;
        sniperKits = 1;
        zapperKits = 1;
        mgText = GameObject.Find("MGText").GetComponent<Text>();
        spText = GameObject.Find("SPText").GetComponent<Text>();
        zpText = GameObject.Find("ZPText").GetComponent<Text>();
        mgText.text = $"x {mgKits}";
        spText.text = $"x {sniperKits}";
        zpText.text = $"x {zapperKits}";


        GameObject[] pastKits = GameObject.FindGameObjectsWithTag("Kit");

        foreach(GameObject kit in pastKits)
        {
            Destroy(kit);
        }
    }
}
