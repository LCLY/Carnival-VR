using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    public class score : MonoBehaviour
    {
        Vector3 oldPos;
        public GameObject gameController;
        basketballScore scoreScript;
        public GameObject bkbCountDownObj;
        bkbCountDown bs;
        AudioSource bkbScoreSound;
        balanceScript bscript;
        // Start is called before the first frame update
        void Start()
        {
            oldPos = transform.position;
            scoreScript = gameController.GetComponent<basketballScore>();
            bs = bkbCountDownObj.GetComponent<bkbCountDown>();
            bkbScoreSound = GameObject.Find("bkbScoreAudio").GetComponent<AudioSource>();
            bscript = GameObject.Find("GameController").GetComponent<balanceScript>();
        }

        bool UC;
        int count = 0;

        void OnTriggerEnter(Collider col)
        {
            /*if(col.name == "Button")
            {
                transform.position = oldPos;
                count = 0;
                Debug.Log("button hit");
            }*/

            if (col.name == "UC")
            {
                UC = true;
            }

            if (col.name == "DC" && UC)
            {
                if (bs.gameBkbStart == true)
                {
                    scoreScript.bkbScore++;
                    bscript.balance += 50;
                    bkbScoreSound.Play();
                }

                UC = false;
                Debug.Log("Count = " + count);
            }
        }
    }
}