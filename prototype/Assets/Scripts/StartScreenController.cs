using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenController : MonoBehaviour
{
    void Update()
    {
        // Check if the player presses the "Enter" key
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Load the main game scene
            SceneManager.LoadScene("Main"); 
        }
    }
}
