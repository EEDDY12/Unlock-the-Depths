using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Arrow : MonoBehaviour
{
    public int damage = 10;
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();
            if (health != null)
                health.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}



