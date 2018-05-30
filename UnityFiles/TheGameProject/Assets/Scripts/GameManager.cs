using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private HUD hud;

    private ObjectController[] objectc;
    public float speed = 10;

	// Use this for initialization
	void Start () {
        hud = FindObjectOfType<HUD>();
        objectc = GameObject.FindWithTag("Platforms").GetComponentInChildren<ObjectController>();
    }
	
	// Update is called once per frame
	void Update () {
        float _points = 100 * Time.deltaTime;
        hud.addPoints(_points);
	}
}
