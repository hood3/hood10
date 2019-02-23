//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Hard : MonoBehaviour
{
    
    public void StartGame()
    {
        WordManager.hasActiveWord = false;
        WordTimer.cat = 3;
        WordManager.points = 100;
        SceneManager.LoadScene("Game");
    }

   
}
