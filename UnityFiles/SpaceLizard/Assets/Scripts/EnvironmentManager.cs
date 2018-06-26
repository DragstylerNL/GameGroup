using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour {

    public int CurrentEnvironment;
    public bool ChangeNow = false;

    public GameObject Env_Mo;
    public GameObject Env_La;
    public GameObject Env_Ea;

	// Use this for initialization
	void Start () {
        SetEnvironment();
    }
	
	// Update is called once per frame
	void Update () {
        if (ChangeNow) { SetNewEnvironment(); ChangeNow = false; }
    }

    public void SetNewEnvironment()
    {
        CurrentEnvironment++;
        if (CurrentEnvironment >= 3) { CurrentEnvironment = 0; }
        SetEnvironment();
    }

    public void SetEnvironment()
    {

        switch (CurrentEnvironment)
        {
            case 0: Env_Mo.SetActive(true);
                    Env_La.SetActive(false);
                    Env_Ea.SetActive(false);
                break;

            case 1: Env_Mo.SetActive(false);
                    Env_La.SetActive(true);
                    Env_Ea.SetActive(false);
                break;

            case 2: Env_Mo.SetActive(false);
                    Env_La.SetActive(false);
                    Env_Ea.SetActive(true);
                break;
        }
    }
}
