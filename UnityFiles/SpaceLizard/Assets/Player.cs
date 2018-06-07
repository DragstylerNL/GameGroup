using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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

        if (other.name == "Peper")
        {
            Destroy(other.gameObject);
            Debug.Log("Peper werkt");
            StartCoroutine(Peper(other));
        }
    }

    IEnumerator Boot(Collider2D other)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.0f);


    }

    IEnumerator Peper(Collider2D other)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.0f);


    }
}
