using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Move(Transform obj, Vector3 direction)
    {
        direction.Normalize();

        obj.position += direction * _speed * Time.deltaTime;
    }
}