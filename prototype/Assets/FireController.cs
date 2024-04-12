using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject characterObject; // Reference to the main character GameObject
    private SpriteRenderer characterSpriteRenderer;
    private SpriteRenderer companionSpriteRenderer;
    public float xOffsetWhenFacingRight = 0.4f; // Offset to adjust companion's position when character faces right
    public float xOffsetWhenFacingLeft = -0.4f; // Offset to adjust companion's position when character faces left
    public GameObject projectilePrefab; // Projectile prefab
    public float projectileSpeed = 10f; // Speed of the projectile
    private Vector2 spawnPosition; // Position to spawn the projectile
    private AudioSource audioSource;
    public AudioClip shootSound; // Sound effect for shooting

    void Start()
    {
        // Find the main character GameObject by its tag 
        GameObject character = GameObject.FindWithTag("Player");

        // Get the SpriteRenderer components
        characterSpriteRenderer = character.GetComponent<SpriteRenderer>();
        companionSpriteRenderer = GetComponent<SpriteRenderer>();   

        // Get the AudioSource component attached to the character
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        // Check the character's facing direction and adjust companion position accordingly
        if (characterSpriteRenderer.flipX)
        {
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingLeft, transform.position.y, transform.position.z);
            if (!companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = true;
            }
        }
        else
        {
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingRight, transform.position.y, transform.position.z);
            if (companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = false;
            }
        }

        // Shoot projectile when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(shootSound);
            Shoot();
        }
    }

    void Shoot()
    {
        // Calculate the position the projectile will spawn at
        spawnPosition = new Vector2(transform.position.x, transform.position.y - 0.01f);

        // Instantiate a projectile at the calculated position
        GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        // Get the projectile's Rigidbody2D component
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        // Determine the direction of the projectile based on the character's facing direction
        Vector2 shootDirection = characterSpriteRenderer.flipX ? Vector2.left : Vector2.right;

        // Set the velocity of the projectile based on the character's direction
        projectileRb.velocity = shootDirection * projectileSpeed;
    }
}
