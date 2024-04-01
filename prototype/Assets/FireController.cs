using UnityEngine;

public class FireController : MonoBehaviour
{
     public GameObject characterObject; // Reference to the main character GameObject
     //reference to the SpriteRenderer component of the main character and companion
    private SpriteRenderer characterSpriteRenderer;
    private SpriteRenderer companionSpriteRenderer;
    // Offset to adjust companion's position when character faces different directions
    public float xOffsetWhenFacingRight = 0.4f;
    public float xOffsetWhenFacingLeft = -0.4f;
     public GameObject projectilePrefab; //  projectile prefab
    public float projectileSpeed = 10f; // Adjust the speed of the projectile
    private Vector2 spawnPosition;// Position to spawn the projectile

    void Start()
    {
        // Find the main character GameObject by its tag 
        GameObject character = GameObject.FindWithTag("Player");

        // Get the SpriteRenderer component from the main character's GameObject
            characterSpriteRenderer = character.GetComponent<SpriteRenderer>();
            companionSpriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void Update()
    {
    // Check if the character is facing right or left
        if (characterSpriteRenderer.flipX)
        {
            // If character is facing left, move companion to the left of the character
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingLeft,transform.position.y,transform.position.z);
            // Flip companion sprite if it's not already flipped
            if (!companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = true;
            }
        }
        else
        {
            // If character is facing right, move companion to the right of the character
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingRight,transform.position.y,transform.position.z);
            // Ensure companion sprite is not flipped
            if (companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = false;
            }
        }

          // Shoot projectile when the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
       void Shoot()
    {
       
           // Calculate the position the     projectile is gonna spawn at
         spawnPosition = new Vector2(transform.position.x, transform.position.y-0.01f);

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
