using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAfter_Seconds : MonoBehaviour {

    public float DiesAfterThisManySeconds;
	
	// Update is called once per frame
	void Start () {
        
            Destroy(this.gameObject, DiesAfterThisManySeconds);
        
	}
}
