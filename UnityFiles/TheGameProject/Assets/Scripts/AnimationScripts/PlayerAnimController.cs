using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour {
    
    //private variables:
    private Animator anim;
    private PlayerController playerController;
    private bool isJumping, isFalling;
    
	void Start () {

        //get the components
        anim = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();

	}
	
	// Update is called once per frame
	void Update () {

        //checking if player has pressed space 
        //and if the player is not on the ground
        //so in the air
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

        //set the animation booleans to be the right state
        anim.SetBool("isJumping", isJumping);
        anim.SetBool("isFalling", isFalling);
		
	}

    //call this to start OR stop an animation
    //name = the name of the bool
    //state = if you want to start the animation or not
    public void animate(string name, bool state)
    {
        //make it work!
        anim.SetBool(name, state);
    }
}
