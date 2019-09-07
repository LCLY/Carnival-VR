using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    public class enableBuy : MonoBehaviour
    {
        public GameObject rightHand;
        SteamVR_LaserPointer laserScript;
        public GameObject laserObj;
        public bool on = false;
        public GameObject buyModeOn;
        // Start is called before the first frame update
        void Start()
        {
            laserScript = rightHand.GetComponent<SteamVR_LaserPointer>();
            laserObj.SetActive(false);
            buyModeOn.SetActive(false);
        }

        public void turnOnOffLaser()
        {
            on = !on;
            if (on)
            {
                laserObj.SetActive(true);
                buyModeOn.SetActive(true);
            }
            else
            {
                laserObj.SetActive(false);
                buyModeOn.SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}