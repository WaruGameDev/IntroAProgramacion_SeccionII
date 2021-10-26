using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFruits : MonoBehaviour
{
    public float timeToSpawn = 3;
    public GameObject fruit;
    public float distanceForRandom = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruitRoutine());
    }
    public void SpawnFruit()
    {
        float randomX = Random.Range(transform.position.x - distanceForRandom, transform.position.x + distanceForRandom);
        Vector3 positionToSpawn = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(fruit, positionToSpawn, Quaternion.identity);
    }

    IEnumerator SpawnFruitRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            SpawnFruit();
            if(timeToSpawn > 0.3f)
            {
                timeToSpawn -= .3f;
            }
        }
    }
    
}
