using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;          // Adjust the speed o

    private Rigidbody2D rb;
     private SpriteRenderer spriteRenderer;
  private LifeManager lifeManager;
 
    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
     spriteRenderer = GetComponent<SpriteRenderer>();
     lifeManager = FindObjectOfType<LifeManager>();
        if (lifeManager == null)
        {
            Debug.LogError("LifeManager not found in the scene.");
        }
     
    }

    void Update()
    {
        // Get player input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput > 0) // Moving right
        {
            spriteRenderer.flipX = false; // No flip
        }
        else if (horizontalInput < 0) // Moving left
        {

            spriteRenderer.flipX = true; // Flip horizontally
        }

        // Calculate movement direction
        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

        // Apply force for movement
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);  
    }

  void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Player hit by enemy!");
            // Call the LoseLife method in the LifeManager script
            if (lifeManager != null)
            {
                lifeManager.LoseLife();
            }
        }
    }

}
