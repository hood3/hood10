using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poop : MonoBehaviour
{

    public GameObject PoopSlicedPrefab;
    public float startForce = 15f;
    public static int NumberOfPoopSliced = 0;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedPoop = Instantiate(PoopSlicedPrefab, transform.position, rotation);
            NumberOfPoopSliced += 1;
            Destroy(slicedPoop, 3f);
            Destroy(gameObject);

        }
    }

    void Update()
    {
        if(NumberOfPoopSliced >= 3)
        {
            SceneManager.LoadScene("End");
        }

    }

}

