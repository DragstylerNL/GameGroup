using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThisWay : MonoBehaviour {

    public Vector3 Movement;
	
	// Update is called once per frame
	void Update () {
        transform.position += Movement * Time.deltaTime;
	}
}
