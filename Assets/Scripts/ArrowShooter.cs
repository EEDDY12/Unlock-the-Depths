using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowShooter : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform[] shootPoints;
    public float arrowSpeed = 20f;
    public AudioSource shootSound; // Add this

    public void ShootArrows()
    {
        // Play shooting sound
        if (shootSound != null)
            shootSound.Play();

        // Shoot arrows
        foreach (Transform point in shootPoints)
        {
            GameObject arrow = Instantiate(arrowPrefab, point.position, point.rotation);
            Rigidbody rb = arrow.GetComponent<Rigidbody>();
            if (rb != null)
                rb.velocity = point.forward * arrowSpeed;
        }
    }
}
