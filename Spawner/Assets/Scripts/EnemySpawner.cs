using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   
    public Transform[] SpawnPoints;
    public GameObject enemyPrefab;

    public void Awake() {

    }

    void Start() {
        SpawnNewEnemy();
    }

    void Update() {
        
    }

    void SpawnNewEnemy() {
        Instantiate(enemyPrefab, SpawnPoints[0].transform.position, Quaternion.identity);

    }
}