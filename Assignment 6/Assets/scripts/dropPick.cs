using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dropPick : MonoBehaviour
{
    public Dropdown dropdown;
    List<string> names = new List<string>() { "Please Select","Start Game", "Quit Game" };

    public void Dropdown_IndexChanged(int index)
    {
        if(index == 1)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            Application.Quit();
        }

    }
    
    void Start()
    {
        PopulateList();        
    }

    void PopulateList()
    {
        dropdown.AddOptions(names);
    }
           
    
}
