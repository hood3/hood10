//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {
    public WordManager wordManager;
	
	void Update () {
        foreach(char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }		
	}
}
