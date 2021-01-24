using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBotsScript : MonoBehaviour
{
    public GameObject explosion;

    public float health = 10;

    public Sprite ten;
    public Sprite nine;
    public Sprite eight;
    public Sprite seven;
    public Sprite six;
    public Sprite five;
    public Sprite four;
    public Sprite three;
    public Sprite two;
    public Sprite one;
    public Sprite zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  

            if ( health <= 0f)
        {
            Debug.Log("u ded Lol");

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(explosion, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
        health = health - 1;
        switch (health)
        {
            case 10:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = ten;
                break;
            case 9:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = nine;
                break;
            case 8:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = eight;
                break;
            case 7:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = seven;
                break;
            case 6:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = six;
                break;
            case 5:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = five;
                break;
            case 4:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = four;
                break;
            case 3:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = three;
                break;
            case 2:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = two;
                break;
            case 1:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = one;
                break;
            case 0:
                gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = zero;
                break;

        }
    }
}
