using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputService : MonoBehaviour, IInputService
{
    public event Action OnJump;
    public event Action OnSwitchCam;
    public event Action OnShoot;
    public Vector2 GetMoveDirection() => _input.Player.Move.ReadValue<Vector2>();

    private PlayerInput _input;

    private void Awake() {
        _input = new PlayerInput();
    }

    private void OnEnable() {
        _input.Enable();

        _input.Player.Jump.performed += context => OnJump?.Invoke();
        _input.Player.Camera.performed += context => OnSwitchCam?.Invoke();
        _input.Player.Shoot.performed += context => OnShoot?.Invoke();
    }

    private void OnDisable() {
        _input.Player.Jump.performed -= context => OnJump?.Invoke();
        _input.Player.Camera.performed -= context => OnSwitchCam?.Invoke();
        _input.Player.Shoot.performed -= context => OnShoot?.Invoke();

        _input.Disable();
    }
}
