using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public GameObject[] pws;
    private SpawnManager sm;

    public float timer = 0;
    public int timerSpeed = 60, speed = 5;
    private int maxRange, minRange = 0;

    public void Start()
    {
        sm = GetComponentInParent<SpawnManager>();
        maxRange = pws.Length;
    }

    private void Update()
    {
        timer += Time.deltaTime * speed;
        if(timer > 60) {
            sm.SpawnPowerup(pws[Random.Range(minRange, maxRange)]);
            timer = 0;
        }
    }
}
