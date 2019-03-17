using UnityEngine;
using System.Collections;

public class Monkey : MonoBehaviour {    
    Animator monkey;
	
	void Start ()
    {
        monkey = GetComponent<Animator>();	
	}

    void Update()
    {
        float run = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        
        if ((Input.GetKey(KeyCode.M)) || (Input.GetKey("joystick button 0")))
        {
            monkey.SetBool("idle", true);            
            monkey.SetBool("run", false);
            monkey.SetBool("runleft", false);
            monkey.SetBool("runright", false);            
        }
        
        if ((Input.GetKey("up")) || (run < -0.7)) 
        {
            monkey.SetBool("run", true);            
            monkey.SetBool("runleft", false);
            monkey.SetBool("runright", false);           
            monkey.SetBool("idle", false);
        }
        if ((Input.GetKey("left")) || (turn < -0.7))
        {
            monkey.SetBool("runleft", true);            
            monkey.SetBool("run", false);
            monkey.SetBool("runright", false);           
            monkey.SetBool("idle", false);
        }    
        if ((Input.GetKey("right")) || (turn > 0.7))
        {
            monkey.SetBool("runright", true);            
            monkey.SetBool("runleft", false);
            monkey.SetBool("run", false);            
            monkey.SetBool("idle", false);
        }      
    }  
}
