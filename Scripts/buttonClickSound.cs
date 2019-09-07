using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClickSound : MonoBehaviour
{
    AudioSource buttonClick;
    // Start is called before the first frame update
    void Start()
    {
        buttonClick = GetComponent<AudioSource>();
    }
    
    public void buttonIsClick()
    {
        buttonClick.Play();
    }
}
