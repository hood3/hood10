using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeControl: MonoBehaviour
{
    public static int time = 0;
    public Dropdown dropdown;
    List<string> Time = new List<string>() { "Please select a Option", "1.5 Minutes", "3 Minutes", "Unlimited"};

    public void Dropdown_timechanged(int index)
    {
        if (index == 1)
        {
            time = 1;           
        }
        if (index == 2)
        {
            time = 2;            
        }
        if (index == 3)
        {
            time = 3;            
        }
       
    }

    void Start()
    {
        PopulateTime();
    }

    void PopulateTime()
    {
        dropdown.AddOptions(Time);
    }
}
