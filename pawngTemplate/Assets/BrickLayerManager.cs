using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayerManager : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float rowSpacing;
    public float colSpacing;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<rows; i++)
        {
            for(int j=0; j<columns; j++)
            {
                float xPos=-1f-columns+(i * colSpacing);
                float yPos=-1.5f+rows-(j * rowSpacing);
                Instantiate(brick, new Vector3(xPos,yPos,0),Quaternion.identity);
            }
        }
        // Instantiate(brick, new Vector3(0,2,0),Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
