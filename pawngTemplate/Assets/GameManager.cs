using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int points;

    public static GameManager S; //singleton
   void Awake() {
        S=this;
    }

    void Start() {
        lives=4;
        // points=0;
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void LoseLife() {
        lives-=1;
        // if (lives<=0) {
        //     // Game Over
        //     Debug.Log("Game Over");
        // }
    }
       public void AddPoint(int numPoints) {
       points+=numPoints;
    }
}
