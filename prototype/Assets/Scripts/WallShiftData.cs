using UnityEngine;

public class WallShiftData : MonoBehaviour
{
    public float shiftAmountX = 1.0f; // Amount to shift the wall on the X axis
    public float shiftAmountY = 1.0f; // Amount to shift the wall on the Y axis
     public Vector3 originalPosition;

        void Start()
    {
        // Store the original position of the wall
        originalPosition = transform.position;
    }
}
