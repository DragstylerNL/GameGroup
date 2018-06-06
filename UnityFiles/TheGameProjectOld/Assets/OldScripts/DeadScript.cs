using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour {

    private HUD hud;

    void Start()
    {
        hud = FindObjectOfType<HUD>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        hud.dead = true;
    }
}
