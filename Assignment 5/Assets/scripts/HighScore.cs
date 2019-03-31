using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
   
    void Start()
    {
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        
    }

   
    void Update()
    {
        if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score.CurrentScore);
        }                    
    }
}
