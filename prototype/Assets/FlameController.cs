using UnityEngine;

public class FlameController : MonoBehaviour
{
     public GameObject characterObject; // Reference to the main character GameObject
     //reference to the SpriteRenderer component of the main character and companion
    private SpriteRenderer characterSpriteRenderer;
    private SpriteRenderer companionSpriteRenderer;
    // Offset to adjust companion's position when character faces different directions
    public float xOffsetWhenFacingRight = 0.4f;
    public float xOffsetWhenFacingLeft = -0.4f;

    void Start()
    {
        // Find the main character GameObject by its tag 
        GameObject character = GameObject.FindWithTag("Player");

        // Get the SpriteRenderer component from the main character's GameObject
            characterSpriteRenderer = character.GetComponent<SpriteRenderer>();
            companionSpriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void Update()
    {
    // Check if the character is facing right or left
        if (characterSpriteRenderer.flipX)
        {
            // If character is facing left, move companion to the left of the character
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingLeft,transform.position.y,transform.position.z);
            // Flip companion sprite if it's not already flipped
            if (!companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = true;
            }
        }
        else
        {
            // If character is facing right, move companion to the right of the character
            transform.position = new Vector3(characterObject.transform.position.x + xOffsetWhenFacingRight,transform.position.y,transform.position.z);
            // Ensure companion sprite is not flipped
            if (companionSpriteRenderer.flipX)
            {
                companionSpriteRenderer.flipX = false;
            }
        }
    }
}
