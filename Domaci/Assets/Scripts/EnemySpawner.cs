using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Vector3> spawnPoints;
    public int numberOfEnemies;

    private System.Random random = new System.Random();
    public GameObject SpawnEnemy(){
        int index = random.Next(0, spawnPoints.Count);
        Vector3 position = spawnPoints[index];
        return  Instantiate(enemyPrefab, position, Quaternion.identity);
        }
    // Start is called before the first frame update
    void Start()
    {
        enemyPrefab.GetComponent<Enemy>().player = GameObject.Find("Player");
        
        for (int i = 0; i < numberOfEnemies; i++)
        {
            GameObject newEnemy = SpawnEnemy();
            spawnedEnemies.Add(newEnemy);            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
