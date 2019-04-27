using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text playerscore;
    public static int score;

    void Start()
    {
        playerscore.text = "Your score: " + score;
    }

    void Update()
    {
        score = (Fruit.NumberOfFruitSliced * 10) - (Poop.NumberOfPoopSliced * 50);
        playerscore.text = "Your score: " + score.ToString();
    }
}
