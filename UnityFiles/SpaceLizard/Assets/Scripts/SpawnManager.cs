using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    private Transform sp_pwr, sp_wrn, sp_rck;

	// Use this for initialization
	void Start () {
        sp_pwr = GameObject.FindGameObjectWithTag("Spawn_Powerup").GetComponent<Transform>();
        sp_wrn = GameObject.FindGameObjectWithTag("Spawn_Warning").GetComponent<Transform>();
        sp_rck = GameObject.FindGameObjectWithTag("Spawn_Rocket").GetComponent<Transform>();
    }
	
    public void SpawnPowerup(GameObject spawnMe)
    {
        GameObject powerup = Instantiate(spawnMe, sp_pwr);
        powerup.transform.parent = null;
    }

    public void SpawnRocket(GameObject Warning, GameObject Rocket)
    {
        GameObject warning = Instantiate(Warning, sp_wrn);
        GameObject rocket = Instantiate(Rocket, sp_rck);
        warning.transform.parent = null;
        rocket.transform.parent = null;
    }

}
