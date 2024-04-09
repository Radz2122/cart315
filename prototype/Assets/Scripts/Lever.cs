using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public GameObject popupText;
     private SpriteRenderer leverRenderer; // Reference to the lever's SpriteRenderer component
      public Sprite leverOnSprite; // Reference to the sprite when the lever is on
    public Sprite leverOffSprite; // Reference to the sprite when the lever is off
      
    void Start(){
        popupText.SetActive(false);
        // Get the SpriteRenderer component attached to the lever GameObject
        leverRenderer = GetComponent<SpriteRenderer>();
      
    }
    void Update()
    {
        // Check for key press (change to your desired key)
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Toggle the lever
            ToggleLever();

        }

    }
      void ToggleLever()
    {
        if (WallShifter.WS.wallsShifted==true)
        {
            // Set lever sprite to on sprite
            leverRenderer.sprite = leverOnSprite;
        }
        else
        {
            // Set lever sprite to off sprite
            leverRenderer.sprite = leverOffSprite;
            // wallsShifted=false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            // Display the popup text
            popupText.SetActive(true);

        }
    }
}
