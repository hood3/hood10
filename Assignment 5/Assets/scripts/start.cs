using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("Main");
    }
}