using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    [SerializeField] private float _tumble = 1f;
    [SerializeField] private Rigidbody _rigidbody;
    
    private void Start()
    {
        _rigidbody.angularVelocity = Random.insideUnitSphere * _tumble;
    }

}
