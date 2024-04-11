using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public GameObject popupText;
     private SpriteRenderer leverRenderer; // Reference to the lever's SpriteRenderer component
      public Sprite leverOnSprite; // Reference to the sprite when the lever is on
    public Sprite leverOffSprite; // Reference to the sprite when the lever is off
    public bool playerIsInFrontOfLever = false; // Indicates whether the player is in front of the lever or not
    public static Lever Lev;
   
     void Awake()
    {
        Lev=this;
    }
      
    void Start(){
        popupText.SetActive(false);
        // Get the SpriteRenderer component attached to the lever GameObject
        leverRenderer = GetComponent<SpriteRenderer>();
        playerIsInFrontOfLever=false;
      
    }
    void Update()
    {
        if (WallShifter.WS.wallsShifted)
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            // Display the popup text
            popupText.SetActive(true);
            playerIsInFrontOfLever = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
               popupText.SetActive(false);
            playerIsInFrontOfLever = false;
    }
}
