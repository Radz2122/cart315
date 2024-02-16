using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakinPaddle : MonoBehaviour {
    private float     xPos;
    public float      paddleSpeed = .05f;
    public float      leftWall, rightWall;

    public KeyCode rightKey, leftKey;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // Get the current position of the paddle
        xPos = transform.localPosition.x;
        if (Input.GetKey(rightKey)) {
            if (xPos > rightWall) {
                xPos += paddleSpeed;
            }
        }

        if (Input.GetKey(leftKey)) {
            if (xPos < leftWall) {
                xPos -= paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);
    }
}

