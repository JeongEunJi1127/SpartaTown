using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : Controller
{
    private Camera camera;
    protected override void Awake()
    {
        base.Awake();
        // MainCamera 태그 붙은 카메라 가져옴
        camera = Camera.main;
    }

    public void OnWalk(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>().normalized;
        CallMoveEvent(direction);
    }
    public void OnLook(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        Vector2 screenPos = camera.ScreenToWorldPoint(direction);
        direction = (screenPos - (Vector2)transform.position).normalized;
        CallLookEvent(direction);
    }
    public void OnRun(InputValue value)
    {
        CallRunEvent();
    }
}
