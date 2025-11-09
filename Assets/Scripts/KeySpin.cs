using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeySpin : MonoBehaviour
{
    public float spinSpeed = 100f;
    public float floatHeight = 0.5f;
    public float floatSpeed = 2f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Rotate animation
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        // Float animation
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

