using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void exitPlay()
    {
        SceneManager.LoadScene("End");
    }
}