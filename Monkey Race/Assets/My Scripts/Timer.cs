﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    private float startTime;
    private bool finnished = false;

    
    void Start()
    {
        startTime = Time.time;        
    }
   
    void Update()
    {
        if (finnished)
        {
            return;
        }
        else
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timer.text = minutes + ":" + seconds;
        }
    }

    public void finnish()
    {
        finnished = true;
        timer.color = Color.yellow;
        
    }
    
}
