using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPlayerName : MonoBehaviour
{
    public void GetInput(string name)
    {
        PlayerPrefs.SetString("Player", name);
    }
}
