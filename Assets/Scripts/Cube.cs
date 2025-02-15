using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover), typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
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
        if (_wayPoints[_index].transform.position == transform.position)
            GetNextWaypoint();

        _mover.Move(transform, _wayPoints[_index].transform.position);
    }

    private void GetNextWaypoint() => _index = ++_index % _wayPoints.Count;
}