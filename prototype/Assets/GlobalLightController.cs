using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GlobalLightController : MonoBehaviour
{
    public Light2D globalLight2D;
    public float newLightIntensity ;

    void Start()
    {
        if (!globalLight2D)
        {
            Debug.LogError("Global Light 2D is not assigned!");
            return;
        }
    }

    void Update()
    {
        // Check for key press (change to your desired key)
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Set the light intensity to the new value when the "E" key is pressed
            SetLightIntensity(newLightIntensity);
        }
    }

    void SetLightIntensity(float intensity)
    {
        if (!globalLight2D)
        {
            Debug.LogError("Global Light 2D is not assigned!");
            return;
        }

        // Set the light intensity
        globalLight2D.intensity = intensity;
    }
}
