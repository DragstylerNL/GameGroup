using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HUD : MonoBehaviour
{
    //private variables:
    private bool fade = false, deadTimerHasStarted = false;
    //timer
    private float timer = 0f, alpha = 0f, deadTimer = 0f;
    //position of the array with sprites or gameObjects
    public int sIndex = 0, aIndex = 0;
    //amount to display on score gameObject
    private int points = 0, prevHealth;
    public int multiplier = 1;

    //dead controls the 
    public bool dead = false, start = true;

    private Animator popUpAnim;

    //public variables:
    //the speed the timer will remove air(health)
    public int timerSpeed = 60;
    public int health = 20;

    //arrays that hold the images and gameObjects for the air(health) UI
    public Image[] airImages;
    public Sprite[] sprites;
    public TextMeshProUGUI popUp;

    //link to the text for the score UI
    public Text pointsText;
    
    private GameObject environmentManager;
    private EnvironmentManager envM;

    public GameObject blackhole;

    public RawImage fadeOutImage;

    private void Start()
    {
        environmentManager = GameObject.FindGameObjectWithTag("EnvironmentManager");
        popUpAnim = popUp.GetComponent<Animator>();
        envM = environmentManager.GetComponent<EnvironmentManager>();
    }

    private void Update()
    {
        
        aIndex = (int)Mathf.Ceil((health - 1)/5);

        points += 1 * multiplier;

        //these are to clean up the Update function
        updateHealth();
        updateScore();
        if (dead)
            beDeadThot();

        if (fade) {
            alpha += 0.1f;
            fadeOutImage.GetComponent<RawImage>().color = new Color(0f, 0f, 0f, alpha);
            if (alpha > 2f) { 
                fade = false;
            }
        }
        
        if(!fade && alpha > 0) {
            alpha -= 0.1f;
            fadeOutImage.GetComponent<RawImage>().color = new Color(0f, 0f, 0f, alpha);
        }
       
    }

    //Update health will update the health UI + the right numbers
    private void updateHealth()
    {

        prevHealth = health;

        //if the timer has started run this code
        if (start && !deadTimerHasStarted) {
            //add to timer contantly
            timer += Time.deltaTime * 60;
            //if timer is bigger then the timerSpeed and the player isn't dead sIndex++
            if (timer > timerSpeed && !dead) {
                //sIndex (Sprite Index) puts the right image in the gameObject Image spots
                health--;
                sIndex = health;
                // reset timer to 0
                timer -= timerSpeed;
            }
        }

        //if the last bar has been reached AND sIndex is on its last sprite
        //player is dead
        if (aIndex == 0 && sIndex == 0 && !deadTimerHasStarted) {
            deadTimerHasStarted = true;
        }
        else if (aIndex != 0 || sIndex != 0) { deadTimerHasStarted = false; deadTimer = 4f; dead = false; }

        if (deadTimerHasStarted)
        {
            if(deadTimer > 0)
            {
                deadTimer -= Time.deltaTime;
                if (deadTimer < 4 && deadTimer > 3f) { if (!popUpAnim.GetBool("DisplayText")) { popUpText("3....", 1); } }
                else if (deadTimer < 3f && deadTimer > 2) { if ( !popUpAnim.GetBool("DisplayText")) { popUpText("2....", 1); } }
                else if (deadTimer < 2) { if ( !popUpAnim.GetBool("DisplayText")){ popUpText("1.......", 2); } }
                if (deadTimer < 0) { dead = true; }
            }
        }

        //update the UI images to the correct sprites last
        if (health != prevHealth)
            updateHealthBar();

    }

    //Call this function to update the healthbar realtime instead on timer speed
    private void updateHealthBar()
    {
        //set the sprite to the right sprites
        airImages[aIndex].sprite = sprites[sIndex];

        //make sure they are empty if health is low enough
        if (health <= 15)
            airImages[airImages.Length - 1].sprite = sprites[0];
        if (health <= 10)
            airImages[airImages.Length - 2].sprite = sprites[0];
        if (health <= 5)
            airImages[airImages.Length - 3].sprite = sprites[0];
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

    //removes air(health) from player
    public void takeDamage(int damage)
    {

        //remove amount of damage from health
        health -= damage;

        //if health is lower than 0 after the damage player is dead
        if(health <= 0) {
            dead = true;
        }

        //update the healthbar individual from the timer speed
        //for instant change in the ui
        updateHealthBar();
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

    private void beDeadThot()
    {
        SceneManager.LoadScene("DeathScreen");
    }

    public void resetAir()
    {
        //set health to max again
        health = 20;

        //set all the sprites back to the full one
        foreach(Image item in airImages) {
            item.sprite = sprites[4];
        }
    }

    public void testfunction(string text)
    {
        popUpText(text, 5.0f);
    }

    public void popUpText(string text, float durationTime)
    {
        if ( !popUpAnim.GetBool("DisplayText")){ StartCoroutine(DisplayText(text, durationTime));}
    }

    IEnumerator DisplayText(string text, float durationTime)
    {
        popUpAnim.SetBool("DisplayText", true);

        popUp.text = text;

        yield return new WaitForSeconds(durationTime);

        popUpAnim.SetBool("DisplayText", false);
    }

    public void fadeOut()
    {
        fade = true;
    }

    public void SpawnBlackhole()
    {
        Debug.Log("Spawning blackhole!");

        GameObject blackholeInst = Instantiate(blackhole, this.transform);

        Vector3 parentPos = this.transform.position;

        blackholeInst.transform.parent = null;
        blackholeInst.transform.position = new Vector3(parentPos.x + 20, parentPos.y - 2, 0);

        points += 20;
    }
}