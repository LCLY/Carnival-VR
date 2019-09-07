using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.Extras
{
    public class basketballScore : MonoBehaviour
    {
        public int bkbScore = 0;
        public int bkbHighScore = 0;

        public GameObject bkbScoreObj;
        Text bkbScoreText;
        public GameObject highScoreObj;
        Text highScoreText;

        // Start is called before the first frame update
        void Start()
        {
            bkbScoreText = bkbScoreObj.GetComponent<Text>();
            highScoreText = highScoreObj.GetComponent<Text>();
            bkbHighScore = PlayerPrefs.GetInt("bkbhighscore", bkbHighScore);
            highScoreText.text = "High Score: " + bkbHighScore.ToString();
        }

        // Update is called once per frame
        void Update()
        {
            bkbScoreText.text = "Score: " + bkbScore.ToString();

            if (bkbScore > bkbHighScore)
            {
                bkbHighScore = bkbScore;
                highScoreText.text = "High Score: " + bkbScore;

                PlayerPrefs.SetInt("bkbhighscore", bkbHighScore);
            }
        }
    }
}