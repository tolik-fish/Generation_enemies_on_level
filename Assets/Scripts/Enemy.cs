using UnityEngine;

[RequireComponent(typeof(Mover), typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    private Mover _mover;
    private Transform _target;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        MoveToTarget();
    }

    public void SetTarget(Transform transform) => _target = transform;

    private void MoveToTarget() => _mover.MoveToTarget(transform, _target);
}