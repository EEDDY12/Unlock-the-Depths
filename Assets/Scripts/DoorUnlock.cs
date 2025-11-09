using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorUnlock : MonoBehaviour
{
    public int keysNeeded = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Inventory.keyCount >= keysNeeded)
            {
                Debug.Log("Door Unlocked!");
                // Example: destroy or animate door
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("You need more keys!");
            }
        }
    }
}

