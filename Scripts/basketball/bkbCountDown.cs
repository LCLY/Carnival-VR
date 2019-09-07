using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Valve.VR.Extras
{
    public class bkbCountDown : MonoBehaviour
    {
        //IN TIMER TV
        Text timeText;
        public float timeLeft = 60f;
        public bool gameBkbOver = true;
        public bool gameBkbStart = false;
        public GameObject gameController;
        basketballScore bs;
        public GameObject barAnimatorObj;
        Animator barAnimator;
        bool hasPlayed = false;

        public GameObject pole;
        moveLeftRight ms;

        // Start is called before the first frame update
        void Start()
        {
            timeText = GetComponent<Text>();
            bs = gameController.GetComponent<basketballScore>();
            barAnimator = barAnimatorObj.GetComponent<Animator>();
            gameBkbOver = true;
            ms = pole.GetComponent<moveLeftRight>();
            ms.amplitude = 0;
        }

        public void startGame()
        {

            if (gameBkbStart == false)
            {
                gameBkbStart = true;
            }
            if (gameBkbOver == true) //if really game over then reset time
            {
                hasPlayed = false;
                timeLeft = 60f;
                gameBkbOver = false;
                bs.bkbScore = 0;
                barAnimator.SetTrigger("gameStart");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (gameBkbStart == true)
            {
                timeLeft -= Time.deltaTime;
            }
            //Debug.Log("timeeleft: "  + timeLeft);
            if (timeLeft <= 30)
            {
                ms.amplitude = 0.5f;//move the pole at 30 seconds
            }

            timeText.text = timeLeft.ToString("F0");
            if (timeLeft < 0)
            {
                ms.amplitude = 0;
                gameBkbStart = false;
                gameBkbOver = true;
                if (hasPlayed == false)
                {
                    barAnimator.SetTrigger("gameOver");
                    hasPlayed = true;
                }
                timeText.text = "0";
            }
        }
    }
}