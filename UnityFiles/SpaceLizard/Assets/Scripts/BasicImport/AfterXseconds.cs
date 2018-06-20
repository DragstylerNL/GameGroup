using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterXseconds : MonoBehaviour {

    public float timer;
    private float timePast;

    public bool move, destoySelf, spawn;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timePast += Time.deltaTime;
        if (timer < timePast)
        {
            if (move) { Move(); }
            if (destoySelf) { DestoySelf(); }
            if (spawn) { Spawn(); }
        }
    }

    void Move() { }
    void DestoySelf() { }
    void Spawn() { }
}
