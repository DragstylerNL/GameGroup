using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAfter_Seconds : MonoBehaviour {

    public float DiesAfterThisManySeconds;

    private float Timer;
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;

        if (Timer > DiesAfterThisManySeconds)
        {
            Destroy(this.gameObject);
        }
	}
}
