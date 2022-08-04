using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour, IJumped
{
    [SerializeField] private float _forse;

    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Jump() {
        _rigidbody.velocity = _rigidbody.velocity + (Vector3.up * _forse);
    }
}
