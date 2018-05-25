using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour {

    Animator anim;
    PlayerController playerController;
    bool isJumping, isFalling;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (!playerController.grounded)
            isFalling = true;
        else
            isFalling = false;

        if(playerController._jumpInput) {
            isJumping = true;
        }
        if(playerController.grounded) {
            isJumping = false;
        }

        anim.SetBool("isJumping", isJumping);
        anim.SetBool("isFalling", isFalling);
		
	}
}
