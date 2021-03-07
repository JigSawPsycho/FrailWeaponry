using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentToCanvas : MonoBehaviour
{

    [SerializeField] float health;
    
    void Start()
    {
        

        Transform parentCanvas = GameObject.Find("CanvasMain").transform;
        
        transform.SetParent(parentCanvas);
    }


    

    
    void Update()
    {
        
    }
}
