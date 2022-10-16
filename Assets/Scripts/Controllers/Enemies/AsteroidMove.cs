using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    [SerializeField] private float _tumble = 1f;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody.angularVelocity = Random.insideUnitSphere * _tumble;
        _rigidbody.velocity = transform.forward * _speed;
    }
}
