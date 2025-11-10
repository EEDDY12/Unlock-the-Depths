using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireTrapController : MonoBehaviour
{
    public ParticleSystem[] fireParticles;   // Array for ALL fire particle systems
    public AudioSource fireSound;            // Looping fire sound (still OK to use 1)

    void Start()
    {
        // Make sure everything is OFF at start
        foreach (var fire in fireParticles)
        {
            if (fire != null)
                fire.Stop();
        }

        if (fireSound != null)
            fireSound.Stop();
    }

    public void ActivateTrap()
    {
        // Turn on all fire particle systems
        foreach (var fire in fireParticles)
        {
            if (fire != null && !fire.isPlaying)
                fire.Play();
        }

        // Start looping fire sound
        if (fireSound != null && !fireSound.isPlaying)
            fireSound.Play();
    }

    public void DeactivateTrap()
    {
        // Turn off all fire particle systems
        foreach (var fire in fireParticles)
        {
            if (fire != null)
                fire.Stop();
        }

        // Stop looping fire sound
        if (fireSound != null)
            fireSound.Stop();
    }
}


