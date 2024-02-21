using UnityEngine;

public class Heart : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("Heart collected");
            // Call a method in LifeManager script to increase player lives
            LifeManager lifeManager = other.GetComponent<LifeManager>();
            if (lifeManager != null)
            {
                lifeManager.AddLife();
            }

            // Destroy the heart
            Destroy(gameObject);
        }
    }
}
