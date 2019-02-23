//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Inter : MonoBehaviour
{
      
    public void StartGame()
    {
        WordManager.hasActiveWord = false;
        WordTimer.cat = 1;
        WordManager.points = 10;
        SceneManager.LoadScene("Game");
    }       

}
   

