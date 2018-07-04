using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private Transform ts;
    private HUD hud;

    public float lifeTime = 5f;

	// Use this for initialization
	void Start () {
        ts = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        ts.position += Vector3.right * Time.deltaTime * -5 ;
        lifeTime -= 1 * Time.deltaTime;
        if(lifeTime < 0f) {
            DeSpawn();
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        { 
            hud = FindObjectOfType<HUD>();

            hud.takeDamage(3);
            DeSpawn();
            
        }
    }

    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}
