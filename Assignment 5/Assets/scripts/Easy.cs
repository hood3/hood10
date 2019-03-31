using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easy : MonoBehaviour
{    
    public void Onclick()
    {
        Car.minSpeed = Car.minSpeed - 4f;
        Car.maxSpeed = Car.maxSpeed -4f;
        SceneManager.LoadScene("Main");
    }   
}
