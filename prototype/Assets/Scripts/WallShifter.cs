using UnityEngine;

public class WallShifter : MonoBehaviour
{
    private bool wallsShifted = false; // Indicates whether the walls have been shifted or not

    // Update is called once per frame
    void Update()
    {
        // Check for button click input
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (wallsShifted)
            {
                RevertWalls();
                wallsShifted = false;
            }
            else
            {
                ShiftWalls();
                wallsShifted = true;
            }
        }
    }

    // Shifts all walls at the same time
    void ShiftWalls()
    {
        // Get all wall objects in the scene
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");

        // Loop through each wall object
        foreach (GameObject wall in walls)
        {
            // Get the WallShiftData component attached to the wall
            WallShiftData wallShiftData = wall.GetComponent<WallShiftData>();

            if (wallShiftData != null)
            {
                // Get the current position of the wall
                Vector3 currentPosition = wall.transform.position;

                // Update the position based on the shift amounts from WallShiftData
                currentPosition.x += wallShiftData.shiftAmountX;
                currentPosition.y += wallShiftData.shiftAmountY;

                // Set the new position of the wall
                wall.transform.position = currentPosition;
            }
        }
    }

    // Reverts all walls back to their original positions
    void RevertWalls()
    {
        // Get all wall objects in the scene
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");

        // Loop through each wall object
        foreach (GameObject wall in walls)
        {
            // Get the WallShiftData component attached to the wall
            WallShiftData wallShiftData = wall.GetComponent<WallShiftData>();

            if (wallShiftData != null)
            {
                // Reset the position of the wall to its original position stored in WallShiftData
                wall.transform.position = wallShiftData.originalPosition;
            }
        }
    }
}
