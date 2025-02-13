using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _delay;

    private Coroutine _coroutine;

    public event Action TimeUpdated;

    private void Awake()
    {
        _coroutine = StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            TimeUpdated?.Invoke();

            yield return wait;
        }
    }
}