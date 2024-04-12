using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed of the player
    public int startingCoins = 0; // Amount of coins player starts with
    public int currentCoins; // Current amount of coins player has
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private LifeManager lifeManager;
    public Text coinsText; // Reference to a UI text element to display the coins
    public GameObject bishops;
    public GameObject popupTextBishop; // Reference to the popup text that appears when player is in front the bishops and they do not have enough money
    private AudioSource audioSource;
    public AudioClip hitSound; // Sound effect for getting hit
    public AudioClip collectSound; // Sound effect for collecting coins

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        // Find and assign the LifeManager script in the scene
        lifeManager = FindObjectOfType<LifeManager>();
        if (lifeManager == null)
        {
            Debug.LogError("LifeManager not found in the scene.");
        }

        // Get the AudioSource component attached to the character
        audioSource = GetComponent<AudioSource>();

        // Deactivate popup text for bishops initially
        popupTextBishop.SetActive(false);
    }

    void Update()
    {
        if (WallShifter.WS.canMove)
        {
            // Get player input for movement
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Flip sprite based on movement direction
            if (horizontalInput > 0) // Moving right
            {
                spriteRenderer.flipX = false; // No flip
            }
            else if (horizontalInput < 0) // Moving left
            {
                spriteRenderer.flipX = true; // Flip horizontally
            }

            // Calculate movement direction
            Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;

            // Apply force for movement
            rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
        }

        // Disable bishops if player has enough coins
        if (currentCoins >= 4)
        {
            bishops.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Player hit by enemy!");
            // Call the LoseLife method in the LifeManager script if it exists
            if (lifeManager != null)
            {
                lifeManager.LoseLife();
                audioSource.PlayOneShot(hitSound);
            }
        }

        if (other.CompareTag("Coins"))
        {
            // Increase coin count and update UI
            currentCoins++;
            Debug.Log("Coin collected");
            Destroy(other.gameObject); // Destroy the coin
            UpdateCoinText(); // Update UI
            audioSource.PlayOneShot(collectSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bishops"))
        {
            // Display popup text if player doesn't have enough coins
            if (currentCoins <= 4)
            {
                popupTextBishop.SetActive(true);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bishops"))
        {
            // Deactivate popup text when player moves away from bishops
            popupTextBishop.SetActive(false);
        }
    }

    void UpdateCoinText()
    {
        // Update the UI text to display the current coin count
        coinsText.text = currentCoins.ToString();
    }
}
