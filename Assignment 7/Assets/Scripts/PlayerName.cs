using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text playerName;

    void Start()
    {
        playerName.text = "Current Player: " + PlayerPrefs.GetString("Player");
    }


}