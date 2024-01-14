using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour 
{
    [SerializeField] private float _moveSpeed = 0.0f;
    [SerializeField] private Vector3 _moveDirection = Vector3.zero;

    public float damage;

    private void Update()
    {
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
    }
    public void MoveTo(Vector3 direction)
    {
        _moveDirection = direction;
    }
}
