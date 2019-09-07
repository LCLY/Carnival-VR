using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{ 

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    
    // Start is called before the first frame update
    void Start()
    {       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentView = views[0];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //default 
            currentView = views[1];           
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //default 
            currentView = views[2];
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //default 
            currentView = views[3];
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            //default 
            currentView = views[4];
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            //default 
            currentView = views[5];
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            //default 
            currentView = views[6];
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            //default 
            currentView = views[7];
        }
    }


    // Update is called once per frame
    void LateUpdate()
    {
        //Lerp the positions
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed), 
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;       
    }
}
