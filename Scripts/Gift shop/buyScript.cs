using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyScript : MonoBehaviour
{
    public GameObject hatPanel;
    public GameObject squishyPanel;
    public GameObject grenadePanel;
    public GameObject lightSaberPanel;
    public GameObject controlCarPanel;
    public GameObject controlRobotPanel;
    public GameObject doll1Panel;
    public GameObject doll2Panel;
    public GameObject doll3Panel;
    public GameObject doll4Panel;
    public GameObject doll5Panel;
    public GameObject doll6Panel;

    // Start is called before the first frame update
    void Start()
    {
        hatPanel.SetActive(false);
        squishyPanel.SetActive(false);
        grenadePanel.SetActive(false);
        lightSaberPanel.SetActive(false);
        controlCarPanel.SetActive(false);
        controlRobotPanel.SetActive(false);
        doll1Panel.SetActive(false);
        doll2Panel.SetActive(false);
        doll3Panel.SetActive(false);
        doll4Panel.SetActive(false);
        doll5Panel.SetActive(false);
        doll6Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
           
            switch (hit.collider.gameObject.name)
            {
                case "JJHaT":
                    Debug.Log("JJHAT!");
                    break;
                case "Squishy":
                    Debug.Log("Squishy!");
                    break;
                case "grenade":
                    Debug.Log("Grenade!");
                    break;
                case "Lightsaber (Kylo)":
                    Debug.Log("lightsaber!");
                    break;
                case "Buggy":
                    Debug.Log("buggy!");
                    break;
                case "JoeJeff":
                    Debug.Log("robot!");
                    break;
                case "doll1":
                    Debug.Log("doll1!");
                    break;
                case "doll2":
                    Debug.Log("doll2!");
                    break;
                case "doll3":
                    Debug.Log("doll3!");
                    break;
                case "doll4":
                    Debug.Log("doll4!");
                    break;
                case "doll5":
                    Debug.Log("doll5!");
                    break;
                case "doll6":
                    Debug.Log("doll6!");
                    break;
                default:
                    break;

            }
          
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
