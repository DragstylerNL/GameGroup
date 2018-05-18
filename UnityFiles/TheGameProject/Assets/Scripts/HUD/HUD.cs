using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    private float timer = 0f;
    public int timerSpeed = 60;
    public int sIndex = 0, aIndex = 0;

    public bool dead = false, start = false;

    public Image[] airImages;
    public Sprite[] sprites;

    private void Update()
    {
        if (start) {
            timer++;
            if (timer % timerSpeed == 0 && !dead) {
                sIndex++;
            }
        }

        if (sIndex > sprites.Length - 1 && aIndex != airImages.Length - 1 && !dead) {
            aIndex++;
            sIndex = 1;
        }

        if (aIndex == airImages.Length - 1 && sIndex > sprites.Length - 2) {
            dead = true;
        }

        airImages[aIndex].sprite = sprites[sIndex];
    }

    public void startTimer()
    {
        this.start = true;
    }

    public void stopTimer()
    {
        this.start = false;
    }

    public void takeDamage()
    {
        if (!dead) {
            if (sIndex > sprites.Length - 1)
                this.sIndex = 1;
            else if (sIndex > 0)
                this.sIndex++;
        }
    }
}
