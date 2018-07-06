using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text last, high;

	// Use this for initialization
	void Start () {
        last.text = "" + PlayerPrefs.GetInt("LastScore", 0);
        high.text = "" + PlayerPrefs.GetInt("MaxScore", 0);
	}
	
	
}
