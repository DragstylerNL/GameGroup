using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOldPlatform : MonoBehaviour {

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        print("ok");
        print(other);
        Destroy(other);
    }
}
