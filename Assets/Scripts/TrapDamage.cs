using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    public int damageAmount = 10;
    public bool damageOverTime = false; // if true, hurts while standing on top
    public float damageInterval = 1f;
    private float timer = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !damageOverTime)
        {
            other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && damageOverTime)
        {
            timer += Time.deltaTime;

            if (timer >= damageInterval)
            {
                other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
                timer = 0f;
            }
        }
    }
}

