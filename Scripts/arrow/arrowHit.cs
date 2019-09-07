using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    public class arrowHit : MonoBehaviour
    {
        public GameObject gameController;
        targetScript ts;
        public GameObject countDownScriptObj;
        countdownTimer countScript;


        public bool watermelon = false;
        public bool pineapple = false;
        public bool apple = false;
        public bool movingTarget = false;

        public bool target1 = false;
        public bool target2 = false;
        public bool target3 = false;
        public bool target4 = false;
        public bool target5 = false;
        public bool target6 = false;

        public AudioClip correct;
        public AudioClip incorrect;
        AudioSource audioSound;

        balanceScript bs;

        int score = 0;

        // Start is called before the first frame update
        void Start()
        {
            ts = gameController.GetComponent<targetScript>();
            audioSound = gameController.GetComponent<AudioSource>();
            countScript = countDownScriptObj.GetComponent<countdownTimer>();
            bs = gameController.GetComponent<balanceScript>();
        }

        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("other stuffs hit!");
            if (collision.gameObject.tag == "projectile")
            {

                if (target1 == true)
                {
                    ts.getHit1();
                    audioSound.clip = incorrect;
                    audioSound.Play();
                    if (countScript.gameStart == true) //only if game already started then can add minus score
                    {
                        ts.archeryTotalScore -= 2;
                    }

                }
                else if (target2 == true)
                {
                    ts.getHit2();
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore++;
                        bs.balance += 10;
                    }
                }
                else if (target3 == true)
                {
                    ts.getHit3();
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore++;
                        bs.balance += 10;
                    }
                }
                else if (target4 == true)
                {
                    ts.getHit4();
                    audioSound.clip = incorrect;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore -= 2;
                    }
                }
                else if (target5 == true)
                {
                    ts.getHit5();
                    audioSound.clip = incorrect;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore -= 2;
                    }
                }
                else if (target6 == true)
                {
                    ts.getHit6();
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore++;
                        bs.balance += 10;
                    }
                }
                else if (watermelon == true)
                {
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore += 3;
                        bs.balance += 30;
                    }
                }
                else if (pineapple == true)
                {
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore += 4;
                        bs.balance += 40;
                    }
                }
                else if (apple == true)
                {
                    audioSound.clip = correct;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore += 10;
                        bs.balance += 100;
                    }
                }
                else if (movingTarget == true)
                {
                    audioSound.clip = incorrect;
                    audioSound.Play();
                    if (countScript.gameStart == true)
                    {
                        ts.archeryTotalScore -= 1;
                    }
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}