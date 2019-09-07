using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeftRight : MonoBehaviour
{    
    public float amplitude = 3f;
    public float frequency = 1f;   
 

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {      
        posOffset = transform.position;
    }


    void startMoving()
    {
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.z += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    // Update is called once per frame
    void Update()
    {       
           startMoving();
    }
}



