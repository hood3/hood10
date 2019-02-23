//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedTyp : MonoBehaviour
{
    public Text yourSpeed;
    public static int wordCompleted;

    void Start()
    {
        yourSpeed = GetComponent<Text>();
    }

    void Update()
    {
        yourSpeed.text = "Your typing speed is: " + wordCompleted.ToString() + " words per minute";
    }
}
