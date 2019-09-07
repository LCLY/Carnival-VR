using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.Extras
{
    public class balanceScript : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
        public GameObject balanceTextObj;
        Text balanceText;
        targetScript ts;
        basketballScore bs;
        public int balance = 10000;       
        //public GameObject rightHand;
        //SteamVR_LaserPointer laserScript;
        // Start is called before the first frame update
        void Start()
        {
            PlayerPrefs.SetInt("balance", balance);
            balanceText = balanceTextObj.GetComponent<Text>();
            ts = GetComponent<targetScript>();
            bs = GetComponent<basketballScore>();
            //laserScript = rightHand.GetComponent<SteamVR_LaserPointer>();
        }

        // Update is called once per frame
        void Update()
        {
            //balance =  PlayerPrefs.GetInt("balance", balance);
            balanceText.text = balance.ToString();           
            //Debug.Log("balance: "  + balance);
           
        }
    }
}