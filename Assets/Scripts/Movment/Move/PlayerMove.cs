using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour, IMovableDirection
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 direction) {
        var directionX = direction.x * _speed * Time.deltaTime;
        var directionZ = direction.y * _speed * Time.deltaTime;
        _rigidbody.MovePosition(_rigidbody.position + new Vector3(directionX, 0, directionZ));
    }
}
