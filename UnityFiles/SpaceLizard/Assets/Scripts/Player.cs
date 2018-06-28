using System.Collections;
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

	// Use this for initialization
	void Start () {
        platformerCharacter2D = this.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();
        hud = camera.GetComponent<HUD>();
        EnvMG = GameObject.FindGameObjectWithTag("EnvironmentManager").GetComponent<EnvironmentManager>();
        spwMG = GameObject.FindGameObjectWithTag("Spawn_Powerup").GetComponent<PowerUp>();
        p_anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "RocketBoot" || other.name == "RocketBoot(Clone)") {
            Destroy(other.gameObject);
            Debug.Log("werkt het???");
            StartCoroutine(Boot(other));
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

    IEnumerator Boot(Collider2D other)
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //yield return new WaitForSeconds(0.0f);

        platformerCharacter2D.SetMaxSpeed(20f);
        
        anim[0].speed = 1f;
        anim[1].speed = 1f;
        anim[2].speed = 1f;
        anim[3].speed = 2f;
        anim[4].speed = 2f;
        anim[5].speed = 2f;
        anim[6].speed = 2f;
        anim[7].speed = 2f;
        hud.multiplier = 2;
        spwMG.speed = 12;

        camera.GetComponent<FollowThePlayer>().ofset_X += 2;
        p_anim.SetBool("Pickup", true);
        p_anim.SetFloat("Speed", 2);

        yield return new WaitForSeconds(effectDuration);

        platformerCharacter2D.SetMaxSpeed(10f);

        anim[0].speed = 0.5f;
        anim[1].speed = 0.5f;
        anim[2].speed = 0.5f;
        anim[3].speed = 1f;
        anim[4].speed = 1f;
        anim[5].speed = 1f;
        anim[6].speed = 1f;
        anim[7].speed = 1f;
        hud.multiplier = 1;
        spwMG.speed = 5;

        camera.GetComponent<FollowThePlayer>().ofset_X -= 2;

        p_anim.SetBool("Pickup", false);
        p_anim.SetFloat("Speed", 1);
    }


    //IEnumerator Peper(Collider2D other)
    //{
    //    //Instantiate(pickupEffect, transform.position, transform.rotation);

    //    yield return new WaitForSeconds(0.0f);


    //}
}
