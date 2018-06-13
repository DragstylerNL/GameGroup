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
<<<<<<< HEAD
            //hud.Boom(this.transform);
            hud.takeDamage();
            Destroy(this.gameObject);
=======
            
>>>>>>> 9916afb5827af657e45f5c65068edd1651ac6d0a
        }
    }
}
