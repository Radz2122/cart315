using UnityEngine;

public class BookController : MonoBehaviour
{
    public float speed = 5f;          // Adjust the speed of the plane
    public float glideForce = 2f;     // Adjust the force applied for gliding
    public float maxGlideSpeed = 8f;  // Adjust the maximum gliding speed

    public GameObject projectilePrefab; // plane projectile prefab
    public float projectileSpeed = 10f; // Adjust the speed of the projectile
    private Rigidbody2D rb;
    private Vector2 spawnPosition;// Position to spawn the projectile
    private LifeManager lifeManager;
     private AudioSource audioSource;
      public AudioClip hitSound;        // Sound effect for getting hit
    public AudioClip shootSound;      // Sound effect for shooting
    public AudioClip collectSound; // sound effect for collecting hearts
    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        lifeManager = FindObjectOfType<LifeManager>();
        if (lifeManager == null)
        {
            Debug.LogError("LifeManager not found in the scene.");
        }

         // Get the AudioSource component attached to the character
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Get player input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

        // Apply force for movement
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);


         // Shoot projectile when the Q key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            // Play shoot sound effect
            PlaySound(shootSound);
        }

    }


     void Shoot()
    {
       
           // Calculate the position the plane projectile is gonna spawn at
         spawnPosition = new Vector2(transform.position.x-0.15f, transform.position.y+0.15f);

        // Instantiate a projectile at the calculated position
        GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        // Get the projectile's Rigidbody2D component
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        // Set the velocity of the projectile based on the book's direction
        projectileRb.velocity = transform.right * projectileSpeed;   
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Call the LoseLife method in the LifeManager script
            if (lifeManager != null)
            {
                lifeManager.LoseLife();
            }
 // Play hit sound effect
            PlaySound(hitSound);
        }

        if (other.CompareTag("heart"))
        {
            PlaySound(collectSound);
        }
    }

       void PlaySound(AudioClip sound)
    {
        // Check if AudioSource and AudioClip are assigned
        if (audioSource != null && sound != null)
        {
            // Play the specified sound effect
            audioSource.PlayOneShot(sound);
        }
        else
        {
            Debug.LogError("AudioSource or AudioClip is missing!");
        }
    }
}
