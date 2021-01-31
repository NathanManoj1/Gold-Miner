using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public int duribility = 25;
    [SerializeField]
    private GameObject _pickaxe;
    public bool _cantMine = true;
    GameManager _gameManager;
    [SerializeField]
    private TextMeshProUGUI _duribility;
    [SerializeField]
    private GameObject _particalsystem;

    private void Start()
    {
        StartCoroutine(Duribility());
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _duribility.text = "Duribility: " + duribility;
            Movement();
        if(duribility == 0)
        {
            _gameManager._Gameover = true;
           
        }
        if(_isTouchingGround == false)
        {
            _particalsystem.SetActive(false);

        }
        else
        {
            _particalsystem.SetActive(true);
        }
    }
 
    void Movement()
    {
        _isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        float x = SimpleInput.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(x, 0);
        _rb.AddForce(_speed * movement);
    }
   private IEnumerator Duribility()
    {
        for (int i = 0; i < 10000000; i++)
        {
            yield return new WaitForSeconds(10);
            duribility++;
        }
       
    }
       
    

   
}
