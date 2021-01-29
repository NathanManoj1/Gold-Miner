using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]
    public float _speed = 1f;
    [SerializeField]
    public float _PowerOfPickaxe;
    public float _JumpSpeed = 8f;
    public bool _isTouchingGround;
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
    }
   
       
    

   
}
