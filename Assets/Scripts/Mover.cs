using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Move(Transform obj, Vector3 direction)
    {
        obj.position = Vector3.MoveTowards(obj.position, direction, _speed * Time.deltaTime);
    }

    public void MoveToTarget(Transform obj, Transform target)
    {
        obj.position = Vector3.MoveTowards(obj.position, target.position, _speed * Time.deltaTime);
    }
}