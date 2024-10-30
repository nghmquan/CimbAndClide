using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player properties")]
    [SerializeField] private Rigidbody2D rigidbodyPlayer;
    [SerializeField] private float speed;
    [SerializeField] private float jumpingPower;
    [SerializeField] private bool isFacing;
    private float horizontal;

    [Header("Ground")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [Header("Wall")]
    [SerializeField] private Transform wallCheck;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private bool isWallJumping;
    [SerializeField] private float wallJumpingTime;
    [SerializeField] private float wallJumpingDuration;
    [SerializeField] private Vector2 wallJumpingPower;
    private float wallJumpingDirection;
    private float wallJumpingCounter;

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Move()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rigidbodyPlayer.velocity = new Vector2(rigidbodyPlayer.velocity.x, jumpingPower);
        }
    }

    private bool IsGrounded()
    {
        throw new NotImplementedException();
    }
}
