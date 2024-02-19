using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 1.0f;  // Adjust the scrolling speed
    public Material cloudsMaterial;    // Reference to your material

    private Material clonedMaterial;   // Clone of the material

    void Start()
    {
        // Clone the material to avoid modifying the original
        clonedMaterial = new Material(cloudsMaterial);
        GetComponent<SpriteRenderer>().material = clonedMaterial;
    }

    void Update()
    {
        // Scroll the background
        float offset = Time.time * scrollSpeed;
        clonedMaterial.mainTextureOffset = new Vector2(0, offset);
    }
}
