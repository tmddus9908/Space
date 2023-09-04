using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    Rigidbody2D _rigid;

    public Vector3 inputVec;
    void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        LimitRange();
    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
    private void Move()
    {
        Vector2 nextVec = inputVec * _speed * Time.fixedDeltaTime;
        _rigid.MovePosition(_rigid.position + nextVec);
    }
    private void LimitRange()
    {
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);
    }
}

