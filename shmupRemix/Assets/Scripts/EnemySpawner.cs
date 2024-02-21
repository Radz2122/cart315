using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;       // Reference to the first type of enemy prefab
    public GameObject newEnemyPrefab;    // Reference to the second type of enemy prefab
    public float spawnIntervalBigBird = 2f;     // Time between enemy spawns
    public float spawnIntervalSmallBird = 4f;     // Time between enemy spawns

    void Start()
    {
        // Start spawning enemies at intervals
        InvokeRepeating("SpawnEnemy", 0f, spawnIntervalBigBird);
        InvokeRepeating("SpawnSmallEnemy", 0f, spawnIntervalSmallBird);
    }

    void SpawnEnemy()
    {
        // Set a random Y position within the screen for both enemy types
        float randomY = Random.Range(-5f, 5f);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);

        // Instantiate the first type of enemy at a random Y position
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnSmallEnemy(){
        // Set a random Y position within the screen for both enemy types
        float randomY = Random.Range(-5f, 5f);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);

        // Instantiate the second type of enemy at a random Y position
        GameObject newEnemyType2 = Instantiate(newEnemyPrefab, spawnPosition, Quaternion.identity);
    }
}
