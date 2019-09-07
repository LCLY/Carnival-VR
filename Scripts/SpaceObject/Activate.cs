using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Attractor
{
    public class Activate : MonoBehaviour
    {
        bool attractor = true;
        bool gravity = false;

        public GameObject attr;
        public GameObject grav;
        Text textA;
        Text textG;

        // Start is called before the first frame update
        void Start()
        {
            textA = attr.GetComponent<Text>();
            textG = grav.GetComponent<Text>();
            disableAttractor();
            disableGravity();
        }

        public void changeAttractor()
        {
            attractor = !attractor;
            if(attractor)
            {
                textA.text = "Attractor\n Off";
            }
            else
            {
                textA.text = "Attractor\n On";
            }
            Debug.Log("attractor = " + attractor);
            if (attractor)
            {
                disableAttractor();
            }
            else
            {
                enableAttractor();
            }
        }

        public void changeGravity()
        {
            gravity = !gravity;
            if (gravity)
            {
                textG.text = "Gravity\n On";
            }
            else
            {
                textG.text = "Gravity\n Off";
            }
            Debug.Log("gravity = " + gravity);
            if (gravity)
            {
                enableGravity();
            }
            else
            {
                disableGravity();
            }
        }


        void enableGravity()
        {
            GameObject[] attractorObjs = GameObject.FindGameObjectsWithTag("attractor");
            foreach (GameObject attractorObj in attractorObjs)
            {
                //enable gravity
                attractorObj.GetComponent<Rigidbody>().useGravity = true;
            }
        }

        void disableGravity()
        {
            GameObject[] attractorObjs = GameObject.FindGameObjectsWithTag("attractor");
            foreach (GameObject attractorObj in attractorObjs)
            {
                //enable gravity
                attractorObj.GetComponent<Rigidbody>().useGravity = false;
            }
        }

        void disableAttractor()
        {
            Attractor[] attractors = FindObjectsOfType<Attractor>();
            foreach (Attractor attractor in attractors)
            {
                attractor.OnDisable();
            }


        }

        void enableAttractor()
        {
            Attractor[] attractors = FindObjectsOfType<Attractor>();
            foreach (Attractor attractor in attractors)
            {
                attractor.OnEnable();
            }
        }
    }
}
