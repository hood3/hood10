using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void OnClick()
    {
        Goal.lifecount = 0;
        Lives.CurrentLife = 3;
        Score.CurrentScore = 0;
        SceneManager.LoadScene(2);           
    }
}