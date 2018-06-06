using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public bool grounded;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.Log(grounded);

        if (transform.position.y < -3.5) {
            grounded = true;
        }

        if(Input.GetKeyDown("Space") && grounded) {
            rb.velocity = Vector2.up * 10;
            Debug.Log("yeah");
        }
    }

}
