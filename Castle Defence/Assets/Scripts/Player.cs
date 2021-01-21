using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]
    private float _speed = 1f;
    [SerializeField]
    public float _PowerOfPickaxe;
    [SerializeField]
    private float _JumpSpeed = 8f;
    private bool _isTouchingGround;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private float groundCheckRadius;
    [SerializeField]
    private Transform groundCheckPoint;

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
        _isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        float x = SimpleInput.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(x, 0);
        _rb.AddForce(_speed * movement);
        if (Input.GetKeyDown(KeyCode.Space) && _isTouchingGround == true)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _JumpSpeed);

        }

    }
    void Jump()
    {

    }
}
