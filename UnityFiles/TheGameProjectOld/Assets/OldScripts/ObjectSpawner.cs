﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    // de 3 posities (hoogtes) waar prefabs kunnen spawnen
    public Transform[] spawnPositions;

    //alle spawnable objects
    public Object[] prefabs;

    // ondergrond prefab
    public Object ground;

    // powerup prefab
    public Object air;
    public Object pwrUp;
    public Object rocket;
    public Object warning;
    // positie voor pwrUps om te spawnen
    public Transform pwUpSpawn;

    public Transform rocketSpawn;
    public Transform warningSpawn;
    public Transform playerPos;

    public int dubbel = 1;

    // timer voordat de nieuwe platform wordt gemaakt
    [Range(0.5f, 5f)]
    public float timerGround;
    public float timerPlatform;
    public float timerPowerUp;
    public float timerRocket;
    public float timerAir;

    // tijd bijhouder
    private float timePastForGround;
    private float timePastForPlatforms;
    private float timePastForPowerUp;
    private float timePastForRocket;
    private float timePastForAir;


    void Start()
    {

    }


    void Update()
    {

        SpawnGround();
        SpawnPlatforms();
        SpawnPowerUp();
        SpawnRocket();
        SpawnAir();

    }

    void SpawnGround()
    {
        // voeg vergaande tijd toe
        timePastForGround += Time.deltaTime * dubbel;

        // kijk of er genoeg tijd is vergaan om een nieuwe prefab te spawnen
        if (timePastForGround > timerGround)
        {
            //grond plaatsen
            Instantiate(ground, spawnPositions[1]);

            //reset
            timePastForGround = 0;
        }
    }

    void SpawnPlatforms()
    {
        // voeg vergaande tijd toe
        timePastForPlatforms += Time.deltaTime;

        if (timePastForPlatforms > timerPlatform)
        {
            // random aantal platforms 
            int i = Mathf.CeilToInt(Random.value * 2);
            if (i == 2)
            {
                int _rndPrefab = Mathf.CeilToInt(Random.value * prefabs.Length) - 1;
                Instantiate(prefabs[_rndPrefab], spawnPositions[0]);
            }

            //reset
            timePastForPlatforms = 0;
        }
    }


    void SpawnPowerUp()
    {
        timePastForPowerUp += Time.deltaTime;

        if (timePastForPowerUp > timerPowerUp)
        {
            Instantiate(pwrUp, pwUpSpawn);
            timePastForPowerUp = 0;
        }
    }

    void SpawnRocket()
    {
        timePastForRocket += Time.deltaTime;

        if (timePastForRocket > timerRocket)
        {

            rocketSpawn.position = new Vector3(rocketSpawn.position.x, playerPos.position.y);
            warningSpawn.position = new Vector3(warningSpawn.position.x, playerPos.position.y);
            Instantiate(rocket, rocketSpawn);
            Instantiate(warning, warningSpawn);
            timePastForRocket = 0;
        }
    }

    void SpawnAir()
    {
        timePastForAir += Time.deltaTime;

        if(timePastForAir > timerAir)
        {
            Instantiate(air);
        }
    }
}