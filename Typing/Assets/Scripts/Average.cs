//Byron Hood
//Game Programming
//Assignment #3
//02-21-2019
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Average : MonoBehaviour
{
    public void StartGame()
    {
        WordManager.hasActiveWord = false;
        WordTimer.cat = 2;
        WordManager.points = 50;
        SceneManager.LoadScene("Game");
    }

}