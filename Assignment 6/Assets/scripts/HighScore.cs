using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

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
            PlayerPrefs.SetString("highname", PlayerPrefs.GetString("Player", name));

            StreamWriter sw = new StreamWriter("Assets/HighScoreTxt.txt");
            sw.WriteLine(PlayerPrefs.GetString("Player",name), Score.CurrentScore);
            sw.Close();
        }                    
    }
}
