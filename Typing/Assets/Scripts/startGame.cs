//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {	
	public void StartGame ()
    {
        WordGenerator.LoadScript();
        SceneManager.LoadScene("SkillLevel");
    }	
}
