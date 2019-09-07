using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetScript : MonoBehaviour
{
    public int archeryTotalScore = 0;
    public int highScore = 0;

    public GameObject countDownTimerObj;
    countdownTimer countScript;

    public GameObject movingTarget;
    moveLeftRight moveScript;

    bool tempGameStart = false;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;

    //1st set
    Animator targetAnimator1;
    Animator targetAnimator2;

    //2nd set
    Animator targetAnimator3;
    Animator targetAnimator4;

    //3rd set
    Animator targetAnimator5;
    Animator targetAnimator6;

    //testing randomize    
    bool stand1 = false;
    bool stand2 = false;
    bool stand3 = false;
    bool stand4 = false;
    bool stand5 = false;
    bool stand6 = false;

    float timeLeft1 = 4f;
    float timeLeft2 = 4f;
    float timeLeft3 = 4f;
    float timeLeft4 = 4f;
    float timeLeft5 = 4f;
    float timeLeft6 = 4f;

    int temp;

    public GameObject scoreTextObj;
    Text scoreText;
    public GameObject highScoreTextObj;
    Text highScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        targetAnimator1 = target1.GetComponent<Animator>();
        targetAnimator2 = target2.GetComponent<Animator>();
        targetAnimator3 = target3.GetComponent<Animator>();
        targetAnimator4 = target4.GetComponent<Animator>();
        targetAnimator5 = target5.GetComponent<Animator>();
        targetAnimator6 = target6.GetComponent<Animator>();
        countScript = countDownTimerObj.GetComponent<countdownTimer>();
        moveScript = movingTarget.GetComponent<moveLeftRight>();
        scoreText = scoreTextObj.GetComponent<Text>();
        highScoreText = highScoreTextObj.GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highscore", highScore);
        highScoreText.text = "High Score: " + highScore.ToString();
    }
    
    void standUp1()
    {
        targetAnimator1.SetTrigger("setup");
        stand1 = true;       
    }

    void standUp2()
    {
        targetAnimator2.SetTrigger("setup");
        stand2 = true;
    }

    void standUp3()
    {
        targetAnimator3.SetTrigger("setup");
        stand3 = true;
    }

    void standUp4()
    {
        targetAnimator4.SetTrigger("setup");
        stand4 = true;
    }

    void standUp5()
    {
        targetAnimator5.SetTrigger("setup");
        stand5 = true;
    }

    void standUp6()
    {
        targetAnimator6.SetTrigger("setup");
        stand6 = true;
    }

    public void getHit1()
    {
        targetAnimator1.SetTrigger("hit");
        timeLeft1 = 4f;
        stand1 = false;
    }

    public void getHit2()
    {
        targetAnimator2.SetTrigger("hit");
        timeLeft2 = 4f;
        stand2 = false;
    }

    public void getHit3()
    {
        targetAnimator3.SetTrigger("hit");
        timeLeft3 = 4f;
        stand3 = false;
    }

    public void getHit4()
    {
        targetAnimator4.SetTrigger("hit");
        timeLeft4 = 4f;
        stand4 = false;
    }

    public void getHit5()
    {
        targetAnimator5.SetTrigger("hit");
        timeLeft5 = 4f;
        stand5 = false;
    }

    public void getHit6()
    {
        targetAnimator6.SetTrigger("hit");
        timeLeft6 = 4f;
        stand6 = false;
    }

    void pair1()
    {
        int random = Random.Range(1, 3);
        //Debug.Log("random: " + random);
        if (random == 1 && !stand2) //if random is 1 and 2 is down
        {   
            if (!stand1) //if 1 is down, make it stand up
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp1", timer);
                stand1 = true;                    
            }
            else 
            {
                //if 1 is not down, make it down after 5 seconds                
                counter1();
            }
        }
        else if (random == 2 && !stand1) //if random is 2 and 1 is down
        {

            if (!stand2) //if 2 is down
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp2", timer);
                stand2 = true;                 
            }
            else 
            {
                //if 2 is not down, make it down after 5 seconds
                counter2();
            }
        }        

    }

    void pair2()
    {
        int random = Random.Range(1, 3);
        //Debug.Log("random: " + random);
        if (random == 1 && !stand4) //if random is 1 and 4 is down
        {
            if (!stand3) //if 3 is down, make it stand up
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp3", timer);
                stand3 = true;           
            }
            else
            {
                //if 3 is not down, make it down after 5 seconds
                counter3();
            }
        }
        else if (random == 2 && !stand3) //if random is 2 and 1 is down
        {

            if (!stand4) //if 2 is down
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp4", timer);
                stand4 = true;                       
            }
            else
            {
                //if 2 is not down, make it down after 5 seconds
                counter4();
            }
        }

    }

    void pair3()
    {
        int random = Random.Range(1, 3);
        //Debug.Log("random: " + random);
        if (random == 1 && !stand6) //if random is 1 and 2 is down
        {
            if (!stand5) //if 1 is down, make it stand up
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp5", timer);
                stand5 = true;         
            }
            else
            {
                //if 1 is not down, make it down after 5 seconds
                counter5();
            }
        }
        else if (random == 2 && !stand5) //if random is 2 and 1 is down
        {

            if (!stand6) //if 2 is down
            {
                float timer = Random.Range(3f, 5f);
                Invoke("standUp6", timer);
                stand6 = true;              
            }
            else
            {
                //if 2 is not down, make it down after 5 seconds
                counter6();
            }
        }

    }
    
    void down1()
    {

        if (stand1) //if 1 or 2 is standing, make them fall
        {
            targetAnimator1.SetTrigger("hit");
            timeLeft1 = 4f;
            stand1 = false;
        }
        else if (stand2)
        {
            targetAnimator2.SetTrigger("hit");
            timeLeft2 = 4f;
            stand2 = false;
        }

    }

    void down2()
    {

        if (stand3) 
        {
            targetAnimator3.SetTrigger("hit");
            timeLeft3 = 4f;
            stand3 = false;
        }
        else if (stand4)
        {
            targetAnimator4.SetTrigger("hit");
            timeLeft4 = 4f;
            stand4 = false;
        }

    }

    void down3()
    {

        if (stand5) 
        {
            targetAnimator5.SetTrigger("hit");
            timeLeft5 = 4f;
            stand5 = false;
        }
        else if (stand6)
        {
            targetAnimator6.SetTrigger("hit");
            timeLeft6 = 4f;
            stand6 = false;
        }

    }

    // Update is called once per frame
    void Update() {

        if (countScript.gameStart == true)
        {
            pair1();

            pair2();

            pair3();

            moveScript.amplitude = 3;
        }
        else
        {
            down1();

            down2();

            down3();

            moveScript.amplitude = 0;
        }      

        scoreText.text = archeryTotalScore.ToString();
      
        if (archeryTotalScore > highScore)
        {
            highScore = archeryTotalScore;
            highScoreText.text = "High Score: " + highScore;

            PlayerPrefs.SetInt("highscore", highScore);
        }

    }
    
    void counter1()
    {
        if (stand1)
        {
            timeLeft1 -= Time.deltaTime;            
            if (timeLeft1 < 0 && stand1)
            {
                targetAnimator1.SetTrigger("hit");
                stand1 = false;
                timeLeft1 = 4f;
            }
        }        
    }

    void counter2()
    {
        if (stand2)
        {
            timeLeft2 -= Time.deltaTime;           
            if (timeLeft2 < 0 && stand2)
            {
                targetAnimator2.SetTrigger("hit");
                stand2 = false;
                timeLeft2 = 4f;
            }
        }       
    }

    void counter3()
    {
        if (stand3)
        {
            timeLeft3 -= Time.deltaTime;          
            if (timeLeft3 < 0 && stand3)
            {
                targetAnimator3.SetTrigger("hit");
                stand3 = false;
                timeLeft3 = 4f;
            }
        }
    }

    void counter4()
    {
        if (stand4)
        {
            timeLeft4 -= Time.deltaTime;
            //Debug.Log("timeLeft4: " + timeLeft4);
            if (timeLeft4 < 0 && stand4)
            {
                targetAnimator4.SetTrigger("hit");
                stand4 = false;
                timeLeft4 = 4f;
            }
        }
    }

    void counter5()
    {
        if (stand5)
        {
            timeLeft5 -= Time.deltaTime;
            //Debug.Log("timeLeft5: " + timeLeft5);
            if (timeLeft5 < 0 && stand5)
            {
                targetAnimator5.SetTrigger("hit");
                stand5 = false;
                timeLeft5 = 4f;
            }
        }
    }

    void counter6()
    {
        if (stand6)
        {
            timeLeft6 -= Time.deltaTime;
            //Debug.Log("timeLeft6: " + timeLeft6);
            if (timeLeft6 < 0 && stand6)
            {
                targetAnimator6.SetTrigger("hit");
                stand6 = false;
                timeLeft6 = 4f;
            }
        }
    }


}
       
 
    
  

