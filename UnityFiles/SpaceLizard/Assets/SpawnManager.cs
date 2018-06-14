using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    private Transform sp_pwr, sp_wrn, sp_rck;

	// Use this for initialization
	void Start () {
        sp_pwr = GameObject.FindGameObjectWithTag("SpawnPowerup").GetComponent<Transform>();
        sp_wrn = GameObject.FindGameObjectWithTag("SpawnWarning").GetComponent<Transform>();
        sp_rck = GameObject.FindGameObjectWithTag("SpawnRocket").GetComponent<Transform>();
    }
	
    public void SpawnPowerup(GameObject spawnMe)
    {
        Instantiate(spawnMe, sp_pwr);
    }

    public void SpawnRocket(GameObject Warning, GameObject Rocket)
    {
        Instantiate(Warning, sp_wrn);
        Instantiate(Rocket, sp_rck);
    }

}
