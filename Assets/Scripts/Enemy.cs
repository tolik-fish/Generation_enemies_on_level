using UnityEngine;

[RequireComponent(typeof(Mover), typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    private Mover _mover;
    private Vector3 _direction;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 vector) => _direction = vector;

    private void Move() => _mover.Move(transform, _direction);
}