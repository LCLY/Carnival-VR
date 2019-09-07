using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGrenade : MonoBehaviour
{
    public GameObject myPrefab;
    //public GameObject spawnPos;
    public GameObject spawnPos2;
    //Vector3 oriPos;
    Vector3 oriPos2;
    // Start is called before the first frame update
    void Start()
    {
        //oriPos = spawnPos.transform.position;
        oriPos2 = spawnPos2.transform.position;   
    }

    public void instantiateGrenade()
    {
       // Instantiate(myPrefab, oriPos, Quaternion.identity);
        Instantiate(myPrefab, oriPos2, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



