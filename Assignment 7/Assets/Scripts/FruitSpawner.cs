using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefabWatermelon;
    public GameObject fruitPrefabOrange;
    public GameObject fruitPrefabApple;
    public GameObject fruitPrefabKiwi;
    public Transform[] spawnPoints;

	//public float minDelay = .1f;
	//public float maxDelay = 1f;

    public static int missedFruit = 0;
	
	void Start () {
		StartCoroutine(SpawnFruits());
	}

	IEnumerator SpawnFruits ()
	{
		while (true)
		{
            float delay = SpawnSpeed.Speed;                            // Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

            if(fruitpick.fruits == 1)
            {
                GameObject spawnedFruit = Instantiate(fruitPrefabWatermelon, spawnPoint.position, spawnPoint.rotation);
                Destroy(spawnedFruit, 5f);
                missedFruit += 1;                
            }
            if (fruitpick.fruits == 2)
            {
                GameObject spawnedFruit = Instantiate(fruitPrefabApple, spawnPoint.position, spawnPoint.rotation);
                Destroy(spawnedFruit, 5f);
                missedFruit += 1;
            }
            if (fruitpick.fruits == 3)
            {
                GameObject spawnedFruit = Instantiate(fruitPrefabOrange, spawnPoint.position, spawnPoint.rotation);
                Destroy(spawnedFruit, 5f);
                missedFruit += 1;
            }
            if (fruitpick.fruits == 4)
            {
                GameObject spawnedFruit = Instantiate(fruitPrefabKiwi, spawnPoint.position, spawnPoint.rotation);
                Destroy(spawnedFruit, 5f);
                missedFruit += 1;
            }            
        }
	}
	
}
