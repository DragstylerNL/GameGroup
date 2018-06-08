using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool RocketInvincible = false;
    public float effectDuration = 2f;

    UnityStandardAssets._2D.PlatformerCharacter2D platformerCharacter2D;
    public GameObject camera;
    HUD hud;

	// Use this for initialization
	void Start () {
        platformerCharacter2D = this.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();
        hud = camera.GetComponent<HUD>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "RocketBoot") {
            Destroy(other.gameObject);
            Debug.Log("werkt het???");
            StartCoroutine(Boot(other));
        }

        if (other.name == "Zuurstof")
        {
            Destroy(other.gameObject);
            Debug.Log("zuurstof werkt");
            hud.resetAir();
            //StartCoroutine(Boot(other));
        }
        //if (other.name == "Peper")
        //{
        //    Destroy(other.gameObject);
        //    Debug.Log("Peper werkt");
        //    StartCoroutine(Peper(other));
        //}
    }

    IEnumerator Boot(Collider2D other)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //yield return new WaitForSeconds(0.0f);

        platformerCharacter2D.SetMaxSpeed(20f);

        yield return new WaitForSeconds(effectDuration);

        platformerCharacter2D.SetMaxSpeed(10f);
    }

    //IEnumerator Peper(Collider2D other)
    //{
    //    //Instantiate(pickupEffect, transform.position, transform.rotation);

    //    yield return new WaitForSeconds(0.0f);


    //}
}
