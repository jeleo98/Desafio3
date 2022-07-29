using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorControler : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float delaySpawn = 1f;
    public float intervalSpawn = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {
       // instantiate(enemyPrefab);

    }

    private void SpawnEnemy()
    {
       int indexEnemy = Random.Range(0, enemyPrefabs.Length);
       Instantiate(enemyPrefabs[indexEnemy],transform);
    }
}
