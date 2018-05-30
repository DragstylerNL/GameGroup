using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBiggerSize : MonoBehaviour
{

    //public float sizeEffect = 1.4f;
    public float effectDuration = 4f;
    public float speed = 10;

    private Transform ts;
    private PlayerAnimController animController;
    public GameObject speler;

    public GameObject pickupEffect;

	void Start()
	{
        ts = GetComponent<Transform>();
        animController = speler.GetComponent<PlayerAnimController>();
	}

	void Update()
	{
        ts.position -= Vector3.right * speed * Time.deltaTime;
	}

	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // kijkt of ie de "Player" aanraakt en voert dan Pickup() funtie uit
        {
            animController.animate("hasRocketBoots", true);
            Time.timeScale = 0;
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

        //wacht x hoeveelheid secondes
        yield return new WaitForSeconds(effectDuration);

        //draait het effect op de player terug
        //player.transform.localScale /= sizeEffect;
        animController.animate("hasRocketBoots", false);

        //verwijder Power-up van scene
        Destroy(gameObject);
    }
}
