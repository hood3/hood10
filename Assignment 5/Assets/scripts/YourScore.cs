using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : MonoBehaviour
{
   public Text youscore;

    void Start()
    {
        youscore.text = "Your Score: " + Score.CurrentScore.ToString();
    }

}
