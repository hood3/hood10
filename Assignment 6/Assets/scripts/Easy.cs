using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easy : MonoBehaviour
{    
    public void Onclick()
    {
        Goal.lifecount = 0;
        Lives.CurrentLife = 3;
        Score.CurrentScore = 0;
        Car.minSpeed = Car.minSpeed - 4f;
        Car.maxSpeed = Car.maxSpeed -4f;
        SceneManager.LoadScene(2);
    }   
}
