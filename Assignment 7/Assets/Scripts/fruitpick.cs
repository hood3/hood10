using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class fruitpick : MonoBehaviour
{
    public static int fruits = 0;
    public Dropdown dropdown;
    List<string> fruit = new List<string>() { "Please select a fruit", "Watermelon", "Apple", "Orange", "Kiwi"};

    public void Dropdown_fruitChanged(int index)
    {
        if(index == 1)
        {
            fruits = 1;            
        }
        if(index == 2)
        {
            fruits = 2;          
        }
        if(index == 3)
        {
            fruits = 3;          
        }
        if (index == 4)
        {
            fruits = 4;           
        }
    }
    
    void Start()
    {
        PopulateFruit();
    }

    void PopulateFruit()
    {
        dropdown.AddOptions(fruit);
    }    
}
