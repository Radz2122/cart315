using UnityEngine;

public class ProjectileController : MonoBehaviour
{
  private Rigidbody2D rb;
  public GameObject item;
   public float probabilityDrop=0.2f;
  void Start(){
    rb = GetComponent<Rigidbody2D>();
  }
    void Update()
    {

      
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

            //maybe spawn an item
           //  if (Random.Range(0f, 1f) < probabilityDrop) // probability 
          //  {
                // Instantiate the heart prefab when the enemy dies
          //      Instantiate(item, transform.position, Quaternion.identity);
          //  }
        }
    }
}
