using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class missingFruit : MonoBehaviour
{
    public TextMeshProUGUI playerMiss;    
    int Miss;

    void Start()
    {
        playerMiss = GetComponent<TextMeshProUGUI>();       
    }

    void Update()
    {
        Miss = FruitSpawner.missedFruit - Fruit.NumberOfFruitSliced;
        playerMiss.text = "# of unsliced fruit: " + Miss.ToString();
        if(Miss >= 6)
        {
            SceneManager.LoadScene("End");
        }
    }
}