using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{
    //IN TIMER TV
    Text timeText;
    public float timeLeft = 30f;
    public bool gameOver = false;
    public bool gameStart = false;
    public GameObject gameOverText;
    public GameObject gameController;
    targetScript ts;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        gameOverText.SetActive(false);
        ts = gameController.GetComponent<targetScript>();
    }

    public void startGame()
    {
        gameStart = true;       
        if(gameOver == true) //if really game over then reset time
        {
            timeLeft = 30f;
            gameOver = false;
            ts.archeryTotalScore = 0;
        }      
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart == true)
        {
            timeLeft -= Time.deltaTime;
        }
     
        timeText.text = "Time: " + timeLeft.ToString("F0") + "s";
        if (timeLeft < 0)
        {
            gameStart = false;
            gameOver = true;
            timeText.text = "Time: 0s";
            gameOverText.SetActive(true);      
        }
    }
}
