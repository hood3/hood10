using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    public TextMeshProUGUI Score;
    int total = 0;   
    
    


    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        total = (Fruit.NumberOfFruitSliced * 10) - (Poop.NumberOfPoopSliced * 50);       
        Score.text = "Score: " + total.ToString();                
    }
}   


