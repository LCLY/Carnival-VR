using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCollider : MonoBehaviour
{
    public GameObject doorObj;
    Animator doorAnim;
    AudioSource doorOpenSound;
    bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {       
        doorAnim = doorObj.GetComponent<Animator>();       
        doorOpenSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;
                if (obj.name == "doorCollider")
                {
                    doorAnim.SetTrigger("open");
                    if (hasPlayed == false)
                    {
                        hasPlayed = true;
                        doorOpenSound.Play();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("Trigger animation");
            doorAnim.SetTrigger("open");
            if(hasPlayed == false)
            {
                hasPlayed = true;
                doorOpenSound.Play();
            }
        }
      
    }
}
