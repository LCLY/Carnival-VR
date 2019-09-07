using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFire : MonoBehaviour
{
    ParticleSystem fire;
    public float timeLeft = 20f;
    // Start is called before the first frame update
    void Start()
    {
        fire = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {       
       /*timeLeft -= Time.deltaTime;
        Debug.Log("timeLeft: " + timeLeft);
        if (timeLeft < 0)
        {
            Destroy(this.gameObject);
            timeLeft = 0;
        }*/
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "grenade")
        {
            fire.Play();
            StartCoroutine(destroyAsteroid());
        }
    }

    IEnumerator destroyAsteroid()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
