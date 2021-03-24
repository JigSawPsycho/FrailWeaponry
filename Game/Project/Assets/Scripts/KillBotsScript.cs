using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBotsScript : MonoBehaviour
{
    public GameObject explosion;
    public GameObject dedScreen;
    public GameObject BaseExplosionSmall;
    public GameObject BaseExplosionMed;
    public GameObject BaseExplosionLarge;
    public GameObject ExplosionPoint;

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
            //Debug.Log("u ded Lol");
            StartCoroutine(Example2());
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Intruder!");
        if (other.gameObject.tag == "Enemy") { 
            Destroy(other.gameObject);
        health = health - 1;
            switch (health)
            {
                case 10:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = ten;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 9:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = nine;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 8:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = eight;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 7:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = seven;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 6:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = six;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 5:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = five;
                    Instantiate(BaseExplosionMed, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 4:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = four;
                    Instantiate(BaseExplosionSmall, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 3:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = three;
                    Instantiate(BaseExplosionMed, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 2:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = two;
                    Instantiate(BaseExplosionMed, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 1:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = one;
                    Instantiate(BaseExplosionMed, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
                case 0:
                    gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = zero;
                    Instantiate(BaseExplosionLarge, ExplosionPoint.transform.position, Quaternion.identity);
                    break;
            }

        }
    }



    IEnumerator Example2()
    {

        yield return new WaitForSeconds(3f);

        PlayerUtil.isGameOver = true;
        dedScreen.SetActive(true);
        //gameObject.SetActive(false);

    }
}
