using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifeManager : MonoBehaviour
{
    public int startingLives = 6;
    private int currentLives;

    public Text livesText;  // Reference to a UI text element to display the remaining lives

    void Start()
    {
        currentLives = startingLives;
        UpdateLivesText();
    }
    //add life only if they ar enot maxed out
public void AddLife()
    {
        if(currentLives < startingLives){
            currentLives+=1;

        // Update the UI text to display the current lives
        UpdateLivesText();
        }
        
    }
    public void LoseLife()
    {
        currentLives--;

        // Check if the player is out of lives
        if (currentLives <= 0)
        {
            SceneManager.LoadScene("GameOver");
            // Implement game over logic if needed
            Debug.Log("Game Over!");
        }

        UpdateLivesText();
    }

    void UpdateLivesText()
    {
        // Update the UI text to display the remaining lives
        livesText.text = "Lives: " + currentLives.ToString();
    }
}
