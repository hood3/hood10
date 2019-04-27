using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpeed : MonoBehaviour
{
    public static float Speed = 0;
    public void onvalueChange(float value)
    {
        Speed = value;
    }    
}
