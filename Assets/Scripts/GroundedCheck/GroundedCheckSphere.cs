using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheckSphere : MonoBehaviour, IGroundedCheck
{
    public LayerMask groundMask => _groundMask;
    public bool isGround => IsGround();

    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private Transform _point;
    [SerializeField] private float _radius;

    private bool IsGround() {
        return Physics.CheckSphere(_point.position, _radius, groundMask);
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_point.position, _radius);
    }
}
