using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkeletonEnemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float attackDistance = 2f;
    public float damageAmount = 10f;
    public float attackCooldown = 1.5f;

    private float attackTimer = 0f;

    private Transform player;
    private Animator anim;
    private CharacterController controller;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        attackTimer += Time.deltaTime;

        if (distance > attackDistance)
        {
            ChasePlayer();
        }
        else
        {
            AttackPlayer();
        }
    }

    void ChasePlayer()
    {
        anim.SetBool("Walk", true);
        anim.SetBool("Idle", false);

        Vector3 dir = (player.position - transform.position).normalized;
        dir.y = 0;

        controller.Move(dir * moveSpeed * Time.deltaTime);
        transform.LookAt(player.position);
    }

    void AttackPlayer()
    {
        anim.SetBool("Walk", false);
        anim.SetBool("Idle", false);

        if (attackTimer >= attackCooldown)
        {
            anim.SetTrigger("Attack");

            // Apply damage
            PlayerHealth health = player.GetComponent<PlayerHealth>();
            if (health != null)
                health.TakeDamage((int)damageAmount);

            attackTimer = 0f;
        }
        else
        {
            anim.SetBool("Idle", true);
        }
    }

    public void Die()
    {
        anim.SetTrigger("Die");
        Destroy(gameObject, 2f);
    }
}
