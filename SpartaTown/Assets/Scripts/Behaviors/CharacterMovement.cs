using System;
using UnityEngine;

// 실질적으로 캐릭터를 움직이게 하는 스크립트
public class CharacterMovement : MonoBehaviour
{
    private Controller controller;
    private Rigidbody2D rigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnRunEvent += Run;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // TODO :: 이동 속도
        movementDirection = direction * 5;
    }

    private void Run()
    {
        // TODO :: 뛰는 속도
        movementDirection *= 2;
    }

    private void ApplyMovement(Vector2 direction)
    {
        rigidbody.velocity = direction;
    }
}