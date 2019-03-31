using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public static int CurrentLife = 3;

    public Text LivesText;

    void Start()
    {
        LivesText.text = "Lives: " + CurrentLife.ToString();
    }

    private void Update()
    {
        if(CurrentLife <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
