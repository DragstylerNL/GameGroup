using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {

    // de positie van deze prefab
    private Transform ts;
    private float platformY;
    // de box colider van het object
    private BoxCollider2D collider2D;
    // de snelheid van het object(eigenllijk die van de player maar die beweegt niet)

    public float speed = 10;


    // positie van de speler
    private GameObject[] player;
    private Transform PlayerTransform;

	void Start () {


        // de positie van deze prefab ophalen
        ts = GetComponent<Transform>();
        platformY = ts.position.y;

        // de collider ophalen
        collider2D = GetComponentInChildren<BoxCollider2D>();
        // player ophalen
        player = GameObject.FindGameObjectsWithTag("Player");
        PlayerTransform = player[0].GetComponent<Transform>();
    }
	

	void Update () {
        // beweeg het platform
        ts.position -= Vector3.right * speed * Time.deltaTime;

        // ervoor zorgen dat je door het platform heen kan springen
        if (collider2D != null && PlayerTransform.position != null)
        {
            float _playerY = PlayerTransform.position.y;
            if (_playerY < ( platformY + 0.3))
                collider2D.enabled = false;
            else
                collider2D.enabled = true;
        }
	}
}
