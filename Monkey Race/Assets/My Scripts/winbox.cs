using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winbox : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("finnish");
        
    }
}
