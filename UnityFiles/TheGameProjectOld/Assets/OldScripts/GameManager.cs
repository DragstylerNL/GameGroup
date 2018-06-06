using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private HUD hud;
    public int dubbel = 1;

	// Use this for initialization
	void Start () {
        hud = FindObjectOfType<HUD>();
    }
	
	// Update is called once per frame
	void Update () {
        float _points = 100 * Time.deltaTime * dubbel;
        hud.addPoints(_points);
	}
}
