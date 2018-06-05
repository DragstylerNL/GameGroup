using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTimer : MonoBehaviour {

    private float Timer = 0;
    public float EndOffTheLine = 6;
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
        if (Timer > EndOffTheLine)
            this.gameObject.SetActive(false);
	}
}
