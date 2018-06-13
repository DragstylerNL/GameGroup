using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    private GameObject Player;
    private Rigidbody2D rb2d;
    private Transform ts;
    
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb2d = Player.GetComponent<Rigidbody2D>();
        ts = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        ts.position += new Vector3(rb2d.velocity.x,0,0) * Time.deltaTime;
	}
}
