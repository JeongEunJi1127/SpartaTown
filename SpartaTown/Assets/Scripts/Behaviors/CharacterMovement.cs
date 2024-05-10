using System;
using UnityEngine;

// ���������� ĳ���͸� �����̰� �ϴ� ��ũ��Ʈ
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
        // TODO :: �̵� �ӵ�
        movementDirection = direction * 5;
    }

    private void Run()
    {
        // TODO :: �ٴ� �ӵ�
        movementDirection *= 2;
    }

    private void ApplyMovement(Vector2 direction)
    {
        rigidbody.velocity = direction;
    }
}