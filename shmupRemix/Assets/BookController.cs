using UnityEngine;

public class BookController : MonoBehaviour
{
    public float speed = 5f;          // Adjust the speed of the plane
    public float glideForce = 2f;     // Adjust the force applied for gliding
    public float maxGlideSpeed = 8f;  // Adjust the maximum gliding speed

    public GameObject projectilePrefab; // plane projectile prefab
    public float projectileSpeed = 10f; // Adjust the speed of the projectile
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
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

        // Apply additional force for gliding if the Glide key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Glide();
        }

         // Shoot projectile when the Q key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shoot();
        }
    }

    void Glide()
    {
        // Limit gliding speed
        float currentSpeed = rb.velocity.magnitude;
        if (currentSpeed < maxGlideSpeed)
        {
            // Apply additional force for gliding
            rb.AddForce(rb.velocity.normalized * glideForce);
        }
    }

     void Shoot()
    {
 
           // Calculate the position in front of the book
        Vector2 spawnPosition = transform.position + transform.right; 

        // Instantiate a projectile at the calculated position
        GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        // Get the projectile's Rigidbody2D component
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

        // Set the velocity of the projectile based on the book's direction
        projectileRb.velocity = transform.right * projectileSpeed;
    }
}
