using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    private Rigidbody rigid;
    private Vector2 movementDirection = Vector2.zero;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        rigid = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        controller.MoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 1;

        rigid.velocity = direction;
    }
}
