using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Vector3> spawnPoints;
    public int numberOfEnemies;

    public GameObject SpawnEnemy() {
        return Instantiate(enemyPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)], Quaternion.identity); 
    }

    public void Awake() {
        spawnedEnemies = new List<GameObject>();
    }

    void Start() {
        for (int i = 0; i < numberOfEnemies; ++i) {
            spawnedEnemies.Add(SpawnEnemy());            
        }
    }

    void Update() {
        
    }
}