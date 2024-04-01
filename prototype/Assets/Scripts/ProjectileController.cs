using UnityEngine;

public class ProjectileController : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the projectile collides with something
        // destroy the projectile upon collision with any object
        Destroy(gameObject);
    }
}
