using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IMovableDirection), typeof(IJumped))]
public class PlayerMovement : MonoBehaviour, IInputMovement
{
    [SerializeField] private GroundedCheckSphere _groundCheckSphere;
    private IInputService _input;

    private IMovableDirection _movable;
    private IJumped _jumped;
    private IGroundedCheck _groundCheck => _groundCheckSphere;

    private void Awake() {
        _movable = GetComponent<IMovableDirection>();
        _jumped = GetComponent<IJumped>();
    }

    public void Init(IInputService input) {
        _input = input;
    }

    private void OnEnable() {
        _input.OnJump += Jump;
    }

    private void OnDisable() {
        _input.OnJump -= Jump;
    }

    private void Jump() {
        if (_groundCheck.isGround) {
            _jumped.Jump();
        }
    }

    private void Update() {
        _movable.Move(_input.GetMoveDirection());
    }
}
