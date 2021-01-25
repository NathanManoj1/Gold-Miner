using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    Player _player;
    Rigidbody2D _rb;
    public Ground[] _ground;
    Shops[] _shop;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        if (_player == null)
            Debug.LogError("Player is NULL");
        _rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        if (_rb == null)
            Debug.LogError("RigidBody2D is NuLL");
        _ground = GameObject.Find("Main Ground").GetComponentsInChildren<Ground>();
        if (_ground == null)
            Debug.LogError("Ground is NULL");
        _shop = GameObject.Find("Canvas").GetComponentsInChildren<Shops>();
       

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jump()
    {
       
        if (_player._isTouchingGround == true)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _player._JumpSpeed);

        }
    }
    public void Dig()
    {
        for (var i = 0; i < _ground.Length; i++)
        {
            _ground[i]._buttonClicked = true;
           
        }
        
      
      
    }
   public void ElectronicShop()
   {
        for (int i = 0; i < _shop.Length; i++)
            _shop[i]._ElectronicButton = true;
   }
    public void PowerUpShop()
    {
        for (int i = 0; i < _shop.Length; i++)
            _shop[i]._PowerUpShop = true;
    }
    public void Bank()
    {
        for(int i = 0; i < _shop.Length; i++)
        {
            _shop[i]._BankButton = true;
        }
       
    }
    public void Xedout()
    {
        for (int i = 0; i < _shop.Length; i++)
        {
            _shop[i]._Shop_Panels[i].SetActive(false);
            _shop[i]._ElectronicButton = false;
            _shop[i]._PowerUpShop = false;
            _shop[i]._BankButton = false;
           
        }
       
    }
}
