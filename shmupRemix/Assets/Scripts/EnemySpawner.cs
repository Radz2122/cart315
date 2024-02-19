using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;      // Reference to enemy prefab
    public float spawnInterval = 2f;    // time between enemy spawns

    void Start()
    {
        // Start spawning enemies at intervals
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Instantiate an enemy at the spawner's position
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
}
