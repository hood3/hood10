using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
    float startForce = FruitSpeedSlider.Speed; 
    public static int NumberOfFruitSliced = 0;    
    Rigidbody2D rb;    

	void Start ()
	{
        transform.localScale = new Vector3(changeFruitSize.Size, changeFruitSize.Size, changeFruitSize.Size);
        rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{            
            Vector3 direction = (col.transform.position - transform.position).normalized;
			Quaternion rotation = Quaternion.LookRotation(direction);     
            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);           
            NumberOfFruitSliced += 1;            
            Destroy(slicedFruit, 3f);
			Destroy(gameObject);     
        }
	}

}
