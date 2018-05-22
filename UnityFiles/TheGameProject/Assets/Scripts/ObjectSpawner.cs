using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    // de 3 posities (hoogtes) waar prefabs kunnen spawnen
    public Transform[] spawnPositions;

    //alle spawnable objects
    public Object[] prefabs;

    // timer voordat de nieuwe platform wordt gemaakt
    [Range(0.5f, 5f)]
    public float timer;
    // tijd bijhouder
    private float timePast;


    void Start () {

    }
	

	void Update () {
        // voeg vergaande tijd toe
        timePast += Time.deltaTime;

        // kijk of er genoeg tijd is vergaan om een nieuwe prefab te spawnen
        if(timePast > timer)
        {
            // random aantal platforms 
            int _rnd = Mathf.CeilToInt(Random.value * 3) - 1;

            for(int i = 0; i < _rnd; i++)
            {
                int _rndPrefab = Mathf.CeilToInt(Random.value * prefabs.Length) - 1;
                Instantiate(prefabs[_rndPrefab], spawnPositions[i]);
            }

            Instantiate(prefabs[2], spawnPositions[3]);

            // timePast weer naar 0
            timePast = 0;
        }

	}
}
