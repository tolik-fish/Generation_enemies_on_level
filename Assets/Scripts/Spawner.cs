using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timer))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> _prefabs;
    [SerializeField] private List<Point> _points;
    [SerializeField] private List<Cube> _targets;

    private Timer _timer;

    private void Awake()
    {
        _timer = GetComponent<Timer>();
    }

    private void OnEnable()
    {
        _timer.TimeUpdated += Spawn;
    }

    private void OnDisable()
    {
        _timer.TimeUpdated -= Spawn;
    }

    private void Spawn()
    {
        int index = GetIndex(0, _points.Count);

        Enemy enemy = Instantiate(_prefabs[index]);

        enemy.transform.position = _points[index].transform.position;

        enemy.SetTarget(_targets[index].transform);
    }

    private int GetIndex(int minNumber, int maxNumber)
    {
        return Random.Range(minNumber, maxNumber);
    }
}