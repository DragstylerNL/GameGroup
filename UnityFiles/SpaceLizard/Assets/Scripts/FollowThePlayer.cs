using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePlayer : MonoBehaviour {

    private Transform ts;
    
    private Transform ts_pl;

    public bool enable_X, enable_Y, enable_Z;
    public float ofset_X, ofset_Y, ofset_Z;

    // Use this for initialization
    void Start () {
        ts = GetComponent<Transform>();
        GameObject pl = GameObject.FindGameObjectWithTag("Player");
        ts_pl = pl.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (enable_X)
            SetX();
        if (enable_Y)
            SetY();
        if (enable_Z)
            SetZ();
        setOfset();
	}

    private void SetX()
    {
        ts.position = new Vector3(ts_pl.position.x, ts.position.y, ts.position.z);
    }

    private void SetY()
    {
        ts.position = new Vector3(ts.position.x, ts_pl.position.y, ts.position.z);
    }

    private void SetZ()
    {
        ts.position = new Vector3(ts.position.x, ts.position.y, ts_pl.position.z);
    }

    private void setOfset()
    {
        ts.position += new Vector3(ofset_X, ofset_Y, ofset_Z);
    }
}
