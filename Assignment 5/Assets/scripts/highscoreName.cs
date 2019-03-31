using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreName : MonoBehaviour
{
    public Text HighScorename;

    void Start()
    {
        HighScorename.text = "The High Score Holder Is: " + PlayerPrefs.GetString("Player", name);
    }
    
}
