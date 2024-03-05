using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public GameObject popupText;
    void Start(){
        popupText.SetActive(false);
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
