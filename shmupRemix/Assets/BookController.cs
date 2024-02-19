using UnityEngine;

public class BookController : MonoBehaviour
{
    public float speed = 5f;          // Adjust the speed of the plane
    public float glideForce = 2f;     // Adjust the force applied for gliding
    public float maxGlideSpeed = 8f;  // Adjust the maximum gliding speed

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
}
