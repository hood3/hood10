using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerfruitslice : MonoBehaviour
{
    public Text playerfruit;
    int fruitslice;

    void Start()
    {
        playerfruit.text = "Number of sliced fruit: " + fruitslice.ToString();
    }

    void Update()
    {
        fruitslice = Fruit.NumberOfFruitSliced;
        playerfruit.text = "Number of sliced fruit: " + fruitslice.ToString();
    }
}
