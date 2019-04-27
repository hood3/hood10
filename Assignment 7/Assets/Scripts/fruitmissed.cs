using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruitmissed : MonoBehaviour
{
    public Text playerfruitMiss;
    int fruitMiss;

    void Start()
    {
        playerfruitMiss.text = "# of unsliced fruit: " + fruitMiss.ToString();
    }

    void Update()
    {
        fruitMiss = FruitSpawner.missedFruit - Fruit.NumberOfFruitSliced;
        playerfruitMiss.text = "# of unsliced fruit: " + fruitMiss.ToString();
    }
}
