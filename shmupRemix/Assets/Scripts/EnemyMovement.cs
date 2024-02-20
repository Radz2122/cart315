using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;          //  the enemy's base movement speed
    public float maxYOffset = 3f;    //  maximum Y offset from the spawn position

    private Rigidbody2D rb;          // Reference to the Rigidbody2D component

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move along the X-axis in a straight line
        rb.velocity = new Vector2(-speed, rb.velocity.y);

        // Randomly move along the Y-axis
        if (Random.Range(0f, 1f) < 0.02f) 
        {
            rb.velocity = new Vector2(rb.velocity.x, Random.Range(-maxYOffset, maxYOffset));
        }

        // Destroy the enemy if it goes off-screen
        if (transform.position.x < -10f || transform.position.y < -5f|| transform.position.y > 5f)
        {
            Destroy(gameObject);
        }
    }
}
