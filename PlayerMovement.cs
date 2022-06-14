using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float JumpForce = 6f;

    bool IsGrounded;
    public LayerMask WhatisGrounded;
    public Transform GroundCheck;
    public float checkRadius;


    private Animator animator;

    [SerializeField] private AudioSource JumpEffect;
    [SerializeField] private AudioSource DieEffect;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();    
 
    }

    private void Update()
    {
            IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, WhatisGrounded);
            PlayerJump();
    }
    //ham nhay va animation
    public virtual void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded == true)
        {
            Vector2 Jump = new Vector2(rigidbody2d.velocity.x, JumpForce);
            rigidbody2d.velocity = Jump;
            JumpEffect.Play();
            animator.SetInteger("State", 1);
        }
        else if (IsGrounded == false)
        {
            animator.SetInteger("State", 0);
        }
    }
    // ham xu lys va cham
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            DieEffect.Play();
            Manager.Instance.RestartloadGame();
        }
    }



}
