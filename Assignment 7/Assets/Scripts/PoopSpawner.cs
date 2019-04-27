using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    public GameObject PoopPrefab;
    public Transform[] spawnPoints;
    public float minDelay = 2.2f;
    public float maxDelay = 4f;

    void Start()
    {
        StartCoroutine(SpawnPoop());
    }

    IEnumerator SpawnPoop()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedPoop = Instantiate(PoopPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedPoop, 5f);
        }
    }

}
