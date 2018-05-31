using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    //private variables:
    //timer
    private float timer = 0f;
    //position of the array with sprites or gameObjects
    private int sIndex = 0, aIndex = 0;
    //amount to display on score gameObject
    private int points = 0;

    //dead controls the 
    public bool dead = false, start = true;

    //public variables:
    //the speed the timer will remove air(health)
    public int timerSpeed = 60;

    //arrays that hold the images and gameObjects for the air(health) UI
    public Image[] airImages;
    public Sprite[] sprites;

    //link to the text for the score UI
    public Text pointsText;
    
    private void Update()
    {

        //these are to clean up the Update function
        updateHealth();
        updateScore();

    }

    //Update health will update the health UI + the right numbers
    private void updateHealth()
    {

        //if the timer has started run this code
        if (start) {
            //add to timer contantly
            timer += Time.deltaTime * 60;
            //if timer is bigger then the timerSpeed and the player isn't dead sIndex++
            if (timer > timerSpeed && !dead) {
                //sIndex (Sprite Index) puts the right image in the gameObject Image spots
                sIndex++;
                // reset timer to 0
                timer -= timerSpeed;
            }
        }

        //if sIndex is greater than the lenght of the Sprites array,
        //so if there are no more sprite to be rendered after this because the health is empty
        //then just reset the sIndex to be the full health sprite AND shift over to the next health bar
        if (sIndex > sprites.Length - 1 && aIndex != airImages.Length - 1 && !dead) {
            aIndex++;
            sIndex = 0;
        }

        //aIndex is for the which health bar to be focused on

        //if the last bar has been reached AND sIndex is on its last sprite
        //player is dead
        if (aIndex == airImages.Length - 1 && sIndex > sprites.Length - 2) {
            dead = true;
        }

        //update the UI images to the correct sprites last
        airImages[aIndex].sprite = sprites[sIndex];
    }

    //updates the Score UI
    private void updateScore()
    {
        //update the text to points integer
        pointsText.text = points.ToString();
    }

    //this starts the timer for the air bar
    public void startTimer()
    {
        start = true;
    }

    //stops the timer for the air bar
    public void stopTimer()
    {
        start = false;
    }

    //removes 1 air point
    public void takeDamage()
    {
        if (!dead) {
            if (sIndex > sprites.Length - 1) {
                sIndex = 1;
            } else if (sIndex >= 0) {
                sIndex++;
            }
        }
    }

    //adds the given amount of points
    public void addPoints(float amount)
    {
        points += Mathf.CeilToInt(amount);
    }

    //subtracts the given amount of points
    public void subPoints(int amount)
    {
        points -= amount;
    }

    //sets the points to the given amount
    public void setPoints(int amount)
    {
        points = amount;
    }

    //resets the points to 0 OR optionally you can send an int along
    public void resetPoints(int amount = 0)
    {
        points = amount;
    }

    //returns the dead variable to see if player is dead or not
    public bool isAlive()
    {
        return dead;
    }

}
