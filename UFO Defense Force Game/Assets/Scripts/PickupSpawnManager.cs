using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{
    public GameObject pickupPrefab;
    public float xSpawnRange;
    public float zSpawnPos;
    public float startDelay = 0.5f;
    public float spawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    void SpawnPickup()
    {
        //Generate the spawn position on the X axis
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0.33f, zSpawnPos);

        //Spawn a Pickup item on the x axis
        Instantiate(pickupPrefab, spawnPos, pickupPrefab.transform.rotation);
    }
}
