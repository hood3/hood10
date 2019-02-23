//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {
    public Text text;
    public static float fallSpeed;
    public void SetWord(string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }
    public void RemoveWord()
    {
        Destroy(gameObject);
    }
	
	private void Update () {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);		
	}
}
