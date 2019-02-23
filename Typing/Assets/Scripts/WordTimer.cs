//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {    
    public WordManager wordmanager;
    public float wordDelay;
    private float nextWordTime = 0f;
    public static int cat;
    
    private void Update()
    {   
        if (cat == 1)
        {
            wordDelay = 8f;
            WordDisplay.fallSpeed = .7f;
        }
        if(cat == 2)
        {
            wordDelay = 3f;
            WordDisplay.fallSpeed = 1f;
        }
        if(cat == 3)
        {
            wordDelay = 1f;
            WordDisplay.fallSpeed = 1.3f;
        }
        if (Time.time >= nextWordTime)
        {            
            wordmanager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }
}
