using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public Transform PlayerImage;
    public Transform PlayerImageUp;
    public Transform PlayerImageDown;
    public Transform PlayerImageLeft;
    public Transform PlayerImageRight;
    public float speed = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            PlayerImage.rotation = Quaternion.Lerp(PlayerImage.rotation, PlayerImageUp.rotation, Time.deltaTime * speed);


        }
        if (Input.GetKey("a"))
        {
            PlayerImage.rotation = Quaternion.Lerp(PlayerImage.rotation, PlayerImageLeft.rotation, Time.deltaTime * speed);

        }
        if (Input.GetKey("s"))
        {
            PlayerImage.rotation = Quaternion.Lerp(PlayerImage.rotation, PlayerImageDown.rotation, Time.deltaTime * speed);

        }
        if (Input.GetKey("d"))
        {
            PlayerImage.rotation = Quaternion.Lerp(PlayerImage.rotation, PlayerImageRight.rotation, Time.deltaTime * speed);

        }
    }
}
