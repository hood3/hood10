using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Start()
    {
        StreamReader sr = new StreamReader("Assets/HighScoreTxt.txt");
        text.text = sr.ReadToEnd();       
    }
}

    


    