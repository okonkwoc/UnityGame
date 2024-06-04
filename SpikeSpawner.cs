using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject spikePrefab; // Assign the Spike prefab in the Inspector
    public float spawnInterval = 1f; // Time between spikes appearing
    public float spikeLifetime = 2f; // How long each spike lasts
    public float spawnRadius = 1f; // Radius around the character to spawn spikes

    void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnSpikes());
    }

    System.Collections.IEnumerator SpawnSpikes()
    {
        while (true)
        {
            SpawnSpike();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnSpike()
    {
        // Calculate a random position around the character
        Vector3 spawnPosition = transform.position + (Random.insideUnitSphere * spawnRadius);
        spawnPosition.y = transform.position.y;

        // Instantiate the spike
        GameObject spike = Instantiate(spikePrefab, spawnPosition, Quaternion.identity);
        
        // Destroy the spike after its lifetime
        Destroy(spike, spikeLifetime);
    }
}