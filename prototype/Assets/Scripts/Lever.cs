using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public GameObject popupText; // Reference to the popup text that appears when player is in front of lever
    public GameObject popupTextCannotUseLever; // Text that appears when player is in front of lever but cannot use it
    private SpriteRenderer leverRenderer; // Reference to the lever's SpriteRenderer component
    public Sprite leverOnSprite; // Sprite when the lever is on
    public Sprite leverOffSprite; // Sprite when the lever is off
    public bool playerIsInFrontOfLever = false; // Indicates whether the player is in front of the lever or not
    public static Lever Lev;

    void Awake()
    {
        Lev = this;
    }

    void Start()
    {
        // Deactivate popup texts at start
        popupText.SetActive(false);
        popupTextCannotUseLever.SetActive(false);

        // Get the SpriteRenderer component attached to the lever GameObject
        leverRenderer = GetComponent<SpriteRenderer>();
        playerIsInFrontOfLever = false;
    }

    void Update()
    {
        // Set lever sprite based on whether walls are shifted or not
        leverRenderer.sprite = WallShifter.WS.wallsShifted ? leverOnSprite : leverOffSprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (WallShifter.WS.canUseLever)
            {
                // Display the popup text
                popupText.SetActive(true);
                playerIsInFrontOfLever = true;
            }
            else
            {
                // Display the popup text indicating the lever cannot be used
                popupTextCannotUseLever.SetActive(true);
                playerIsInFrontOfLever = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Deactivate all popup texts and reset lever state when player moves away
        popupText.SetActive(false);
        popupTextCannotUseLever.SetActive(false);
        playerIsInFrontOfLever = false;
    }
}
