using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FootStepAudio : MonoBehaviour

{
    public AudioSource audioSource;
    public AudioClip walkClip;
    public AudioClip sprintClip;

    public float walkInterval = 0.5f;
    public float sprintInterval = 0.35f;

    CharacterController controller;
    PlayerInput playerInput;

    InputAction moveAction;
    InputAction sprintAction;

    float stepTimer = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Move"];
        sprintAction = playerInput.actions["Sprint"];
    }

    void Update()
    {
        Vector2 move = moveAction.ReadValue<Vector2>();
        bool isMoving = Mathf.Abs(move.x) > 0.01f || Mathf.Abs(move.y) > 0.01f;
        bool isGrounded = controller.isGrounded;
        bool isSprinting = sprintAction.IsPressed();

        Debug.Log("Move: " + move + "  isMoving: " + isMoving);

        if (isGrounded && isMoving)
        {
            stepTimer -= Time.deltaTime;

            if (stepTimer <= 0f)
            {
                PlayFootstep(isSprinting);
                stepTimer = isSprinting ? sprintInterval : walkInterval;
            }
        }
        else
        {
            stepTimer = 0f;

            // HARD STOP footsteps when not walking
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }

    void PlayFootstep(bool sprinting)
    {
        audioSource.pitch = Random.Range(0.95f, 1.05f);
        audioSource.PlayOneShot(sprinting ? sprintClip : walkClip);
    }
}



