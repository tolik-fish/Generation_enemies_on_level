using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover), typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private int _index;
    [SerializeField] private List<Point> _wayPoints;

    private Mover _mover;

    private void Awake()
    {
        _mover = GetComponent<Mover>();

        _index--;
    }

    private void Update()
    {
        if (IsWaypointReached())
            DetermineNextWaypoint();

        _mover.Move(transform, _wayPoints[_index].transform.position);
    }

    private bool IsWaypointReached()
    {
        return transform.position.IsEnoughClose(_wayPoints[_index].transform.position, _distance);
    }

    private void DetermineNextWaypoint() => _index = ++_index % _wayPoints.Count;
}