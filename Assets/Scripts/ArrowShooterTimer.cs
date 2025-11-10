using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowShooterTimer : MonoBehaviour
{
    public ArrowShooter shooter;   // Reference to the shooter script
    public float interval = 2f;    // Time between shots

    void Start()
    {
        // Make sure there is a shooter assigned
        if (shooter == null)
        {
            shooter = GetComponent<ArrowShooter>();
        }

        InvokeRepeating(nameof(Fire), interval, interval);
    }

    void Fire()
    {
        if (shooter != null)
        {
            shooter.ShootArrows();
        }
        else
        {
            Debug.LogWarning("ArrowShooterTimer has no shooter assigned!");
        }
    }
}
