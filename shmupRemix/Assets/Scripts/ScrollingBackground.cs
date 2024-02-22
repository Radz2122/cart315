using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class ScrollingBackground : MonoBehaviour {
    public float speed;
    [SerializeField] private Renderer bgRenderer;
 
    void Update()
    {
        //move the background in a loop
        bgRenderer.material.mainTextureOffset += new Vector2(speed* Time.deltaTime,0);
    }
}
 