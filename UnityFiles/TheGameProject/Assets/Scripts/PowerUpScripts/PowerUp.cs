using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float sizeEffect = 1.4f;
    public float effectDuration = 4f;

    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // kijkt of ie de "Player" aanraakt en voert dan Pickup() funtie uit
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        //spawns een pickup effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //geeft power-up effect aan Player
        player.transform.localScale *= sizeEffect;

        //zorgt dat de power-up niet blijft maar ontzichbaar wordt
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        //wacht x hoeveelheid secondes
        yield return new WaitForSeconds(effectDuration);

        //draait het effect op de player terug
        player.transform.localScale /= sizeEffect;

        //verwijder Power-up van scene
        Destroy(gameObject);
    }
}
