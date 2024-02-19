using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;  // Adjust the enemy's movement speed
  private Rigidbody2D rb;

  void Start(){
    rb = GetComponent<Rigidbody2D>();
  }
    void Update()
    {
        // Move the enemy downward (adjust as needed for your game)
        rb.velocity = transform.right * -speed;
        // transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Destroy the enemy if it goes off-screen
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }

      
    }
}
