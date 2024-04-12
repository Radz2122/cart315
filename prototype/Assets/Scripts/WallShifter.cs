using UnityEngine;
using System.Collections;
public class WallShifter : MonoBehaviour
{
    public static WallShifter WS;
    public Camera mainCamera; // Reference to main camera
    public float zoomedOutSize = 12f; // Orthographic size when zoomed out
    public float zoomedInSize = 2.5f; // Orthographic size when zoomed in
    public float wallShiftDuration = 4f; // Duration of wall shifting animation in seconds
    public UnityEngine.Rendering.Universal.Light2D globalLight2D; // Reference to the global light
    public float newLightIntensity; // New intensity the light will have once the lever is pulled and the cam is zoomed out
    public GameObject popupText;//ref to the popup text that appears when player is in front of lever
    public bool wallsShifted = false; // Indicates whether the walls have been shifted or not
    private Vector3[] originalPositions; // Array to store the original positions of the walls
    public bool canMove = true; // Indicates whether the player can move or not
    private AudioSource audioSource;
    public AudioClip wallMoveSound; // Sound effect for the wall movement
    public AudioClip leverSound; // Sound effect for the lever

 void Awake()
    {
        WS=this;
    }
  void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Shifts all walls with animation
    IEnumerator ShiftWallsCoroutine()
    {
        
        float elapsedTime = 0f;

        // Get all wall objects in the scene
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");

        // Store the original positions of the walls
        originalPositions = new Vector3[walls.Length];
        for (int i = 0; i < walls.Length; i++)
        {
            originalPositions[i] = walls[i].transform.position;
        }

     // Turn on the light
        SetLightIntensity(newLightIntensity);
        // Zoom out the camera
        while (mainCamera.orthographicSize < zoomedOutSize)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, zoomedOutSize, elapsedTime / wallShiftDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
            canMove = false; // Prevent the player from moving while the walls are shifting
        }
        AudioSource.PlayClipAtPoint(wallMoveSound, transform.position, 1f);
        // Shift the walls
        while (elapsedTime < wallShiftDuration)
        {
            
            for (int i = 0; i < walls.Length; i++)
            {
                WallShiftData wallShiftData = walls[i].GetComponent<WallShiftData>();
                if (wallShiftData != null)
                {
                    Vector3 targetPosition = originalPositions[i] + new Vector3(wallShiftData.shiftAmountX, wallShiftData.shiftAmountY, 0f);
                    walls[i].transform.position = Vector3.Lerp(originalPositions[i], targetPosition, elapsedTime / wallShiftDuration);
                }
            }
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Set the final position of walls
        for (int i = 0; i < walls.Length; i++)
        {
            WallShiftData wallShiftData = walls[i].GetComponent<WallShiftData>();
            if (wallShiftData != null)
            {
                Vector3 targetPosition = originalPositions[i] + new Vector3(wallShiftData.shiftAmountX, wallShiftData.shiftAmountY, 0f);
                walls[i].transform.position = targetPosition;
            }
        }

        wallsShifted = true; // Set wallsShifted to true after shifting walls

        // Turn off the light
        SetLightIntensity(0.1f);

        // Zoom in the camera
        while (mainCamera.orthographicSize > zoomedInSize)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, zoomedInSize, elapsedTime / wallShiftDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        
        canMove = true; // Allow the player to move again
    }

    // Reverts all walls back to their original positions with animation
    IEnumerator RevertWallsCoroutine()
    {
        float elapsedTime = 0f;

        // Get all wall objects in the scene
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
    // Turn on the light
        SetLightIntensity(newLightIntensity);
        // Zoom out the camera
        while (mainCamera.orthographicSize < zoomedOutSize)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, zoomedOutSize, elapsedTime / wallShiftDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
            canMove = false; // Prevent the player from moving while the walls are shifting
        }
        AudioSource.PlayClipAtPoint(wallMoveSound, transform.position, 1f);

        // Revert the walls to their original positions
        while (elapsedTime < wallShiftDuration)
        {
            
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].transform.position = Vector3.Lerp(walls[i].transform.position, originalPositions[i], elapsedTime / wallShiftDuration);
            }
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Set the final position of walls
        for (int i = 0; i < walls.Length; i++)
        {
            walls[i].transform.position = originalPositions[i];
        }

        wallsShifted = false; // Set wallsShifted to false after reverting walls
     
        // Turn off the light
        SetLightIntensity(0.1f);

        // Zoom in the camera
        while (mainCamera.orthographicSize > zoomedInSize)
        {
            mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, zoomedInSize, elapsedTime / wallShiftDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
           canMove = true; // Allow the player to move again
    }

    // Update is called once per frame
    void Update()
    {
        // Check for button click input
        if (Lever.Lev.playerIsInFrontOfLever && Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(leverSound);
            
            popupText.SetActive(false);//deactivate it
            if (!wallsShifted)
            {
                StartCoroutine(ShiftWallsCoroutine());
            }
            else
            {
                StartCoroutine(RevertWallsCoroutine());
            }
        }
    }

    // Set light intensity
    void SetLightIntensity(float intensity)
    {
        if (globalLight2D != null)
        {
            globalLight2D.intensity = intensity;
        }
        else
        {
            Debug.LogError("Global Light 2D is not assigned!");
        }
    }
}



 
