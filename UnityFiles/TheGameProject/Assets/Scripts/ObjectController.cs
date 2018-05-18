using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {

    // de positie van deze prefab
    private Transform ts;
    // de snelheid van het object(eigenllijk die van de player maar die beweegt niet)
    public float speed = 10;

	void Start () {
        // de positie van deze prefab ophalen
        ts = GetComponent<Transform>();
	}
	

	void Update () {
        ts.position -= Vector3.right * speed * Time.deltaTime;
	}
}
