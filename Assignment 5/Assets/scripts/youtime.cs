using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youtime : MonoBehaviour
{
    public Text YourTime;

    void Start()
    {
        YourTime.text = "Your Time: " + Timer.minutes.ToString() + ": " + Timer.seconds.ToString(); 
    }    
}
