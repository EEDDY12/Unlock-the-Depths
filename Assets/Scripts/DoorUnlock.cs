using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorUnlock : MonoBehaviour
{
    public int keysNeeded = 1;
    [Header("Inscribed")]
    public GameObject daDoor;

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         if (Inventory.keyCount >= keysNeeded)
    //         {
    //             Debug.Log("Door Unlocked!");
    //             // Example: destroy or animate door
    //             Destroy(daDoor);
    //         }
    //         else
    //         {
    //             Debug.Log("You need more keys!");
    //         }
    //     }
    // }
    public void DestroyDoor() {
        if (Inventory.keyCount >= keysNeeded)
            {
                //Debug.Log("Door Unlocked!");
                // Example: destroy or animate door
                Destroy(daDoor);
            }
            // else
            // {
            //     //Debug.Log("You need more keys!");
            // }
    }
    void Update()
    {
        DestroyDoor();
    }
}

