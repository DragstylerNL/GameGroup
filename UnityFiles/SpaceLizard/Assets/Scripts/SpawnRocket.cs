using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour {

    public GameObject warning, rocket;
    private SpawnManager sm;

    public float timer = 0;
    public float TimeToMustHavePast = 10;
    public int speed = 5;

    public void Start()
    {
        sm = GetComponentInParent<SpawnManager>();
    }

    private void Update()
    {
        timer += Time.deltaTime * speed;
        if (timer > TimeToMustHavePast)
        {
            sm.SpawnRocket(warning, rocket);
            timer = 0;
        }
    }
}
