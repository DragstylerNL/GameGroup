using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BundeledRocketScript : MonoBehaviour {

    private float timer;
    private Transform ts;
    [Range(0,360)]
    public float StartBonus;
    [Range(.5f, 10)]
    public float timeMultiplier;


    // Use this for initialization
    void Start () {
        ts = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        SpinRocket();
	}

    void SpinRocket()
    {
        timer += Time.deltaTime * 10 * timeMultiplier;
        ts.position = new Vector3(ts.position.x, ts.position.y + ((Mathf.Cos(timer + StartBonus)) / 10), 0);
    }
}
