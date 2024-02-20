using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
  private Rigidbody2D rb;

  void Start(){
    rb = GetComponent<Rigidbody2D>();
  }
    void Update()
    {

        // Destroy the projectile if it goes off-screen
        if (transform.position.x>10f)
        {
            Destroy(gameObject);
        }

        //if it is still on screen and touches an enemy...
        if (transform.position.x<=10f)
        {
            //insert code to kill enemy
        }
      
    }
    //destroy enemy and projectile on collision
     void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the projectile hits an enemy
        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy and the projectile
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject);       // Destroy the projectile
            Score.S.UpdateScore();     // Update the score
        }
    }
}
