using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public AudioClip Squash;
    public AudioClip Hop;

    void Update () {
        
		if ((Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKey("joystick button 1")))
        {
            rb.MovePosition(rb.position + Vector2.right);
            GetComponent<AudioSource>().PlayOneShot(Hop, 0.1f);
        }			
		else if ((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKey("joystick button 2")))
        {
            rb.MovePosition(rb.position + Vector2.left);
            GetComponent<AudioSource>().PlayOneShot(Hop, 0.1f);
        }           
		else if ((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKey("joystick button 3")))
        {
            rb.MovePosition(rb.position + Vector2.up);
            GetComponent<AudioSource>().PlayOneShot(Hop, 0.1f);
        }            
		else if ((Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKey("joystick button 0")))
        {
            rb.MovePosition(rb.position + Vector2.down);
            GetComponent<AudioSource>().PlayOneShot(Hop, 0.1f);
        }           
        else if ((Input.GetKeyDown(KeyCode.M)) || (Input.GetKey("joystick button 5")))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
       

    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
            Lives.CurrentLife -= 1;            
            GetComponent<AudioSource>().PlayOneShot(Squash, 0.1f);           
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);              
        }
	} 
    
    
}
