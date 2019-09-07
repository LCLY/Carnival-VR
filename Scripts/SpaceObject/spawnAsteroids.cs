using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroids : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject myPrefab1;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    public GameObject myPrefab4;
   
    public GameObject spawnPos;
    public GameObject spawnPos1;
    public GameObject spawnPos2;
    public GameObject spawnPos3;
    public GameObject spawnPos4;

    Vector3 oriPos;
    Vector3 oriPos1;
    Vector3 oriPos2;
    Vector3 oriPos3;
    Vector3 oriPos4;
    // Start is called before the first frame update
    void Start()
    {
        oriPos = spawnPos.transform.position;
        oriPos1 = spawnPos1.transform.position;
        oriPos2 = spawnPos2.transform.position;
        oriPos3 = spawnPos3.transform.position;
        oriPos4 = spawnPos4.transform.position;
    }

    public void instantiateAsteroids()
    {
        GameObject[] respawns = GameObject.FindGameObjectsWithTag("attractor");
     
       if(respawns.Length > 30)
        {
            //cannot instantiate
            Debug.Log("cannot instantiate");
        }else
        {
            Instantiate(myPrefab, oriPos, Quaternion.identity);
            Instantiate(myPrefab1, oriPos1, Quaternion.identity);
            Instantiate(myPrefab2, oriPos2, Quaternion.identity);
            Instantiate(myPrefab3, oriPos3, Quaternion.identity);
            Instantiate(myPrefab4, oriPos4, Quaternion.identity);
        }      
    }

    // Update is called once per frame
    void Update()
    {

    }
}
