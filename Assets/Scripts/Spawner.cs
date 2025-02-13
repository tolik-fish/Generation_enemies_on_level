using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timer))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private List<Point> _points;

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
        Enemy enemy = Instantiate(_prefab);

        enemy.transform.position = GetPosition();

        enemy.SetDirection(GetDirection());
    }

    private Vector3 GetDirection()
    {
        float minRandom = -100f;
        float maxRandom = 100f;

        float x = Random.Range(minRandom,maxRandom);
        float y = 0f;
        float z = Random.Range(minRandom, maxRandom);

        return new Vector3(x, y, z);
    }

    private Vector3 GetPosition()
    {
        int minRandom = 0;

        int random = Random.Range(minRandom, _points.Count);

        return _points[random].transform.position;
    }
}