using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
            
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Your bonus points:\n" +scoreValue;
    }
}
