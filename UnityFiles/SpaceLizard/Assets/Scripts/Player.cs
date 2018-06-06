using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject pickupEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name=="RocketBoot"){

            //animController.animate("hasRocketBoots", true);
            Destroy(other.gameObject);
            Debug.Log("Rocktet schoen opgepakt");
            StartCoroutine(BootPickup(other));
        }

        if(other.name=="Peper"){
            Destroy(other.gameObject);
            Debug.Log("Peppertje opgepakt");
            StartCoroutine(PeperPickup(other));
        }

        if(other.name=="Orb"){
            Destroy(other.gameObject);
            Debug.Log("Orb opgepakt");
            StartCoroutine(OrbPickup(other));
        }
    }

    IEnumerator PeperPickup(Collider2D other){

        Instantiate(pickupEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.0f);

        //animController.animate("hasRocketBoots", false);
    }

    IEnumerator BootPickup(Collider2D other){

        Instantiate(pickupEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.0f);

        //animController.animate("hasRocketBoots", false);
    }

    IEnumerator OrbPickup(Collider2D other){

        Instantiate(pickupEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.0f);

        //animController.animate("hasRocketBoots", false);
    }
}
