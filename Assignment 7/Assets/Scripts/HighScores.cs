using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class HighScores : MonoBehaviour
{
    public TextMeshProUGUI HighScore;

    void Awake()
    {
        HighScore = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        StreamReader sr = new StreamReader("Assets/HighScoreTxt.txt");
        HighScore.text = sr.ReadToEnd();
    }
}