using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoopSlice : MonoBehaviour
{
    public Text playerpoop;
    int poopslice;

    void Start()
    {
        playerpoop.text = "Number of sliced poop: " + poopslice.ToString();
    }

    void Update()
    {
        poopslice = Poop.NumberOfPoopSliced;
        playerpoop.text = "Number of sliced poop: " + poopslice.ToString();
    }
}
