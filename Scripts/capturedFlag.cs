using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    public class capturedFlag : MonoBehaviour
    {
        AudioSource successMusic;
        balanceScript bscript;
        // Start is called before the first frame update
        void Start()
        {
            successMusic = GetComponent<AudioSource>();
            bscript = GameObject.Find("GameController").GetComponent<balanceScript>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "robot")
            {
                successMusic.Play();
                bscript.balance += 10000;
                Debug.Log("win!");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}