
using System;
using System.Collections;




using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    [SerializeField] private float timeOnClick;
    [SerializeField] private bool hasClicked;
    [SerializeField] private int spawnRate;

    void Start()
    {
        Debug.Log("Start");


    }


    void Update()
    {

        timeOnClick = Time.time;

        if (Input.GetMouseButtonDown(0) && !hasClicked)
        {
            Debug.Log("working");
            hasClicked = true;
            Debug.Log("Your Time Is " + timeOnClick + " Seconds");
            timeOnClick = 0;
        }

    }




}