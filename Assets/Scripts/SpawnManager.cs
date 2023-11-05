using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject[] spawnObstales;
    private float posY = 1.0f;
    private float posZ = 4.5f;
    private float startSpawn = 1.0f;
    private float repeatCall = 1.0f;

    void Start() {
        InvokeRepeating("SpawnObstacles", startSpawn, repeatCall);
    }

    void Update() {
        
    }

    void SpawnObstacles() {
        float randomPosX = Random.Range(-6.0f, 4.0f);
        int indexPrefab = Random.Range(0 , spawnObstales.Length);
        Instantiate(spawnObstales[indexPrefab], new Vector3(randomPosX, posY, posZ), spawnObstales[indexPrefab].transform.rotation);
    }
}
