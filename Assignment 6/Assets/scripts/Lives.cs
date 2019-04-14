using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public static int CurrentLife = 0;

    public Text LivesText;

    void Start()
    {
        LivesText.text = "Lives: " + CurrentLife.ToString();        
    }

    void Update()
    {
        if (CurrentLife <= 0)
        {
            SceneManager.LoadScene("End");
        }
        
    }    
}
