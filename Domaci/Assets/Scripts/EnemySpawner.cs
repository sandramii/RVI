using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> spawnPoints = new List<Transform>();
    public int spawnTime;
    public List<GameObject> instantiatedEnemies;
    public int maxEnemyCount;
    private int enemyCount;

    private System.Random randomIndex = new System.Random();
    public IEnumerator SpawnCoroutine(int timeForSpawn) {
        while(true) {
            int index = randomIndex.Next(0, spawnPoints.Count);
            Vector3 spawnPosition = spawnPoints[index].position;

            GameObject instantiatedEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            instantiatedEnemies.Add(instantiatedEnemy);
            enemyCount++;

            if(enemyCount >= maxEnemyCount)
            {
                yield break;
            }
            
            yield return new WaitForSecondsRealtime(timeForSpawn);
        }
    }    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));
        enemyPrefab.GetComponent<Enemy>().player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}