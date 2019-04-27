using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerSliced : MonoBehaviour
{
    public TextMeshProUGUI playersli;
    int slice;

    void Start()
    {
        playersli = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        slice = Fruit.NumberOfFruitSliced;
        playersli.text = "# of sliced fruit: " + slice.ToString();
    }
}