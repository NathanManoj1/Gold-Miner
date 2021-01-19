using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]
    private float _speed = 1f;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(x, 0);
        _rb.AddForce(_speed * movement);
    }
}
