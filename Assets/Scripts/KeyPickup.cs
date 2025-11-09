using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPickup : MonoBehaviour
{
    public int keyID = 0;   // optional if you want different keys

       public AudioSource pickupSound;

    private void Start()
    {
        pickupSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the trigger
        if (other.CompareTag("Player"))
        {
            // Add key to inventory manager (you create this later or skip it)
            Inventory.keyCount++;

            // Play the pickup sound
            AudioSource.PlayClipAtPoint(pickupSound.clip, transform.position);

            // Hide key immediately but destroy after sound finishes
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            Debug.Log("Key Picked! Total keys: " + Inventory.keyCount);

            // Destroy key object
            Destroy(gameObject);
        }
    }
}


