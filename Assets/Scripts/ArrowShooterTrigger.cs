using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ArrowShooterTrigger : MonoBehaviour
{
    public ArrowShooter shooter;      // Reference to the ArrowShooter script

    private void Start()
    {
        if (shooter == null)
            shooter = GetComponent<ArrowShooter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shooter.ShootArrows();
        }
    }
}

