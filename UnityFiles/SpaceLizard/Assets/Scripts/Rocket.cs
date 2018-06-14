using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private Transform ts;
    private HUD hud;

	// Use this for initialization
	void Start () {
        ts = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        ts.position += Vector3.right * Time.deltaTime * -20 ;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        { 
            hud = FindObjectOfType<HUD>();

            //hud.Boom(this.transform);
            hud.takeDamage(1);
            Destroy(this.gameObject);
            
            hud.takeDamage(3);
            Destroy(this.gameObject);

            hud.takeDamage(0);
            Destroy(this.gameObject);
            
        }
    }
}
