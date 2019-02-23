//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void StartGame()
    {
        WordGenerator.LoadScript();
        SceneManager.LoadScene("SkillLevel");
    }
}



