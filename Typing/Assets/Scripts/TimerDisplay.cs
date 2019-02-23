//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerDisplay : MonoBehaviour {
    public Text Timer;
    private float startTime = 65f;
    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }	
	void Start () {
        Timer = GetComponent<Text>();        
	}	
	
	void Update () {
        startTime -= Time.deltaTime;
        Timer.text = startTime.ToString("f2");
        if(startTime <= 0)
        {
            EndGame();
        }        
	}
}
