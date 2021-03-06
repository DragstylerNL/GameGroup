﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool RocketInvincible = false;
    public float effectDuration = 5f;

    public Animator[] anim;
    private Animator p_anim;

    UnityStandardAssets._2D.PlatformerCharacter2D platformerCharacter2D;
    public GameObject camera;
    HUD hud;    

    EnvironmentManager EnvMG;
    PowerUp spwMG;

    private GameObject environmentManager;
    private EnvironmentManager envM;

    public float timer = 0f;
    private float cmTimer = 0;
    private bool cmBool = false;

    // Use this for initialization
    void Start () {
        environmentManager = GameObject.FindGameObjectWithTag("EnvironmentManager");
        envM = environmentManager.GetComponent<EnvironmentManager>();
        platformerCharacter2D = this.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();
        hud = camera.GetComponent<HUD>();
        EnvMG = GameObject.FindGameObjectWithTag("EnvironmentManager").GetComponent<EnvironmentManager>();
        spwMG = GameObject.FindGameObjectWithTag("Spawn_Powerup").GetComponent<PowerUp>();
        p_anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += 1f * Time.deltaTime;
        if(timer > 10f) {
            hud.SpawnBlackhole();
            timer = 0f;
        }

        if (cmTimer > 0 && !cmBool)
        {
            cmTimer -= 0.05f;
            camera.GetComponent<FollowThePlayer>().ofset_X += 0.1f;
        }
        if (cmTimer > 0 && cmBool)
        {
            cmTimer -= 0.05f;
            camera.GetComponent<FollowThePlayer>().ofset_X -= 0.1f;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "RocketBoot" || other.name == "RocketBoot(Clone)") {
            Destroy(other.gameObject);
            Debug.Log("werkt het???");
            StartCoroutine(Boot(other));
        }

        if(other.name == "Blackhole" || other.name == "Blackhole(Clone)") {
            Destroy(other.gameObject);
            Debug.Log("Blackhole touched!");
            StartCoroutine(Blackhole());
        }

        if (other.name == "Zuurstof" || other.name == "Zuurstof(Clone)")
        {
            Destroy(other.gameObject);
            Debug.Log("zuurstof werkt");
            hud.resetAir();
            //StartCoroutine(Boot(other));
        }
        //if (other.name == "Peper")
        //{
        //    Destroy(other.gameObject);
        //    Debug.Log("Peper werkt");
        //    StartCoroutine(Peper(other));
        //}
    }

    IEnumerator Blackhole()
    {
        hud.fadeOut();

        GameObject[] rockets = GameObject.FindGameObjectsWithTag("Rocket");
        
        foreach (GameObject rocket in rockets) {
            rocket.GetComponent<Rocket>().DeSpawn();
        }
        
        yield return new WaitForSeconds(0.2f);

        envM.SetNewEnvironment();
        envM.GetEnvironment();

        hud.popUpText("You've just entered a blackhole that has taken you to " + envM.GetEnvironment() + "!", 3f);
    }

    private int powerups = 0;

    IEnumerator Boot(Collider2D other)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //yield return new WaitForSeconds(0.0f);

        powerups++;

        platformerCharacter2D.SetMaxSpeed(20f);
        
        anim[0].speed = 2f;
        anim[1].speed = 2f;
        anim[2].speed = 2f;
        anim[3].speed = 2f;
        anim[4].speed = 2f;
        anim[5].speed = 2f;
        anim[6].speed = 2f;
        anim[7].speed = 2f;

        hud.multiplier = 2;
        spwMG.speed = 10;
        
        p_anim.SetFloat("Speed", 2);

        if (!p_anim.GetBool("Pickup") && powerups>0) {
            cmTimer = 1;
            cmBool = false;
        }

        p_anim.SetBool("Pickup", true);

        yield return new WaitForSeconds(effectDuration);

        powerups--;

        if (powerups == 0)
        {
            platformerCharacter2D.SetMaxSpeed(10f);
            p_anim.SetBool("Pickup", false);
            p_anim.SetFloat("Speed", 1);
            anim[0].speed = 1f;
            anim[1].speed = 1f;
            anim[2].speed = 1f;
            anim[3].speed = 1f;
            anim[4].speed = 1f;
            anim[5].speed = 1f;
            anim[6].speed = 1f;
            anim[7].speed = 1f;
            hud.multiplier = 1;
            spwMG.speed = 5;
        }

        if (!p_anim.GetBool("Pickup") && powerups == 0)
        {
            cmTimer = 1;
            cmBool = true;
        }
    }


    //IEnumerator Peper(Collider2D other)
    //{
    //    //Instantiate(pickupEffect, transform.position, transform.rotation);

    //    yield return new WaitForSeconds(0.0f);


    //}
}
