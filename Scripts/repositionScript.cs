using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repositionScript : MonoBehaviour
{
    Vector3 oriPos;
    GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        oriPos = this.transform.position;
        playerPrefab = GameObject.Find("Player");
        playerPrefab.transform.position = oriPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
