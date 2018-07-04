using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingSign : MonoBehaviour {

    public float lifeTime = 3f;
	
	// Update is called once per frame
	void Update () {
        lifeTime -= 1 * Time.deltaTime;
        if(lifeTime < 0f) {
            DeSpawn();
        }
	}

    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}
