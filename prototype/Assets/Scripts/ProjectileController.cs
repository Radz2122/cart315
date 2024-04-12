using UnityEngine;

public class ProjectileController : MonoBehaviour
{
  private Rigidbody2D rb;
  public GameObject item;
  public float probabilityDrop = 0.2f;
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  //destroy enemy and projectile on collision
  void OnTriggerEnter2D(Collider2D other)
  {
    Destroy(gameObject);
    // Check if the projectile hits an enemy
    if (other.CompareTag("Enemy"))
    {

      // Destroy the enemy and the projectile
      Destroy(other.gameObject);
    }
  }
}
