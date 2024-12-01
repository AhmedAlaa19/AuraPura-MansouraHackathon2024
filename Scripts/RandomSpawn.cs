using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSpawn : MonoBehaviour
{    
    [SerializeField] private SpriteRenderer spriteRenderer1;

    private bool done1 = false;
    private bool done2 = false;
    private bool done3 = false;

    [SerializeField] private SpriteRenderer spriteRenderer2;

    [SerializeField] private SpriteRenderer spriteRenderer3;

    [SerializeField] private GameObject clickDetector1;

    [SerializeField] private GameObject clickDetector2;

    [SerializeField] private GameObject clickDetector3;

    [SerializeField] private float delayTime;
    void Start()
    {
        Debug.Log("Game Started");

        test1();


    }

   
    void Update()
    {
        if (done1) 
        {
            spriteRenderer2.enabled = false;
            clickDetector2.SetActive(false);
            delayTime = Random.Range(5f, 8f);
            Invoke("ShowSprite2", delayTime);

            done2 = true;
            done1 = false;

            spriteRenderer1.enabled = false;
            clickDetector1.SetActive(false);

        }


        if (done2)
        {
            spriteRenderer3.enabled = false;
            clickDetector3.SetActive(false);
            delayTime = Random.Range(8f, 11f);
            Invoke("ShowSprite3", delayTime);

            done3 = true;
            done2 = false;

            spriteRenderer2.enabled = false;
            clickDetector2.SetActive(false);
        }
    }


    private void ShowSprite1()
    {
        spriteRenderer1.enabled = true;
        clickDetector1.SetActive(true);

    }
    private void ShowSprite2()
    {
        spriteRenderer2.enabled = true;
        clickDetector2.SetActive(true);

    }
    private void ShowSprite3()
    {
        spriteRenderer3.enabled = true;
        clickDetector3.SetActive(true);

    }

    private void test1()
    {
        spriteRenderer1.enabled = false;
        clickDetector1.SetActive(false);
        delayTime = Random.Range(2f, 5f);
        Invoke("ShowSprite1", delayTime);

        done1 = true;
    }

  
}
