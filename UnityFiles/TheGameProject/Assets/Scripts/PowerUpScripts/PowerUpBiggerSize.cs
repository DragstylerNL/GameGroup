using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBiggerSize : MonoBehaviour
{

    //public float sizeEffect = 1.4f;
    public float effectDuration = 6f;
    public float speed = 10;

    private Transform ts;
    private int superSpeed = 10;
    private PlayerAnimController animController;
    public GameObject speler;
    private GameObject[] platforms;

    public GameObject pickupEffect;

	void Start()
	{
        ts = GetComponent<Transform>();
        animController = speler.GetComponent<PlayerAnimController>();
        platforms = GameObject.FindGameObjectsWithTag("Ground");
	}

	void Update()
	{
        ts.position -= Vector3.right * speed * Time.deltaTime;
        platforms = GameObject.FindGameObjectsWithTag("Ground");
        foreach (GameObject obj in platforms) {
            if(obj.gameObject != null)
                obj.GetComponent<ObjectController>().speed = superSpeed;
        }
        
    }

	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // kijkt of ie de "Player" aanraakt en voert dan Pickup() funtie uit
        {
            animController.animate("hasRocketBoots", true);
            stopPlatforms();
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
     
        //spawns een pickup effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //geeft power-up effect aan Player
        //player.transform.localScale *= sizeEffect;

        //zorgt dat de power-up niet blijft maar ontzichbaar wordt
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(0.7f);
        
        //can't be exported outside of iEnumerator gives NULL reference
        superSpeed = 20;

        //wacht x hoeveelheid secondes
        yield return new WaitForSeconds(effectDuration);
        platforms = GameObject.FindGameObjectsWithTag("Ground");
        superSpeed = 10;

        //draait het effect op de player terug
        //player.transform.localScale /= sizeEffect;
        animController.animate("hasRocketBoots", false);

        //verwijder Power-up van scene
        Destroy(gameObject);
    }

    public void stopPlatforms()
    {
        superSpeed = 0;
    }
}
