//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour {
    public static int finalScore; 
    public Text yourScore;

    void Start () {
        yourScore = GetComponent<Text>();
    }
	
	void Update () {
        yourScore.text = "Your Score: " + finalScore.ToString();
    }
}
