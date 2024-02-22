using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
  private Rigidbody2D rb;
  public float probabilityDrop=0.2f;
 public GameObject heartPrefab; 
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
      
    }
    //destroy enemy and projectile on collision
     void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the projectile hits an enemy
        if (other.CompareTag("Enemy"))
        {
        
            // Destroy the enemy and the projectile
            Destroy(other.gameObject); 
            Destroy(gameObject);       
            Score.S.UpdateScore();     // Update the score

            //maybe spawn a heart
             if (Random.Range(0f, 1f) < probabilityDrop) // probability 
            {
                // Instantiate the heart prefab when the enemy dies
                Instantiate(heartPrefab, transform.position, Quaternion.identity);
            }
        }
        if (other.CompareTag("Enemy2"))
        {
            // Destroy the enemy and the projectile
            Destroy(other.gameObject); 
            Destroy(gameObject);      
            Score.S.UpdateScore2();     // Update the score

        }
    }
}
