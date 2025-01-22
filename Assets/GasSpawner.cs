using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSpawner : MonoBehaviour
{
    public GameObject GasCube;
    private Vector3[] spawnPoints = new Vector3[3];
    public float spawnPeriod = 7f;

    public void Start()
    {
        spawnPoints[0] = new Vector3(0, 0.5f, 13);
        spawnPoints[1] = new Vector3(-1, 0.5f, 13);
        spawnPoints[2] = new Vector3(1, 0.5f, 13);
        
        
        StartCoroutine(GasSpawnerCoroutine());
    }

    IEnumerator GasSpawnerCoroutine()
    {
        while(true)
        {
            Vector3 spawnPoint = spawnPoints[Random.Range(0, 2)];
            Instantiate(GasCube, spawnPoint, Quaternion.identity);
            yield return new WaitForSeconds(spawnPeriod);
        }
    }
}
