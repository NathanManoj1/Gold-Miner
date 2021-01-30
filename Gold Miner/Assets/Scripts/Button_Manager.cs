using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    Player _player;
    Rigidbody2D _rb;
    public Ground[] _ground;
    Shops[] _shop;
    UI_Manager _uiManager;
    [SerializeField]
    public bool _hasMoneyMultiplier;
    [SerializeField]
    private GameObject _creditsMenu;
    [SerializeField]
    private GameObject _howToPlayMenu;
    [SerializeField]
    private GameObject _startMenu;

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
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        if (_uiManager == null)
            Debug.LogError("UI Manager is NULL");
      


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
      
            _shop[2]._ElectronicButton = true;
   }
    public void PowerUpShop()
    {
       
            _shop[0]._PowerUpShop = true;
    }
    public void Bank()
    {
       
            _shop[1]._BankButton = true;
        
       
    }
    public void Xedout()
    {
        
        for (int i = 0; i <_shop[i].Shop_Buttons.Length; i++)
        {
         _shop[i].Shop_Buttons[i].SetActive(true);
        }
        for (int i = 0; i < _shop.Length; i++)
        {
            _shop[i]._Shop_Panels[i].SetActive(false);
            _shop[i]._ElectronicButton = false;
            _shop[i]._PowerUpShop = false;
            _shop[i]._BankButton = false;
           
        }
       
    }
    //ADD IT SO IF YOU DON'T HAVE ANY THING THEN A MESSAGE APPERARS.
    public void Bank_sell_TV()
    {
        if(_hasMoneyMultiplier == true)
        {
            _uiManager.TV--;
            _uiManager.UpdateCoins(100);
        }
        if (_uiManager.TV > 0)
        {
            _uiManager.TV--;
            _uiManager.UpdateCoins(75);
        }
    }
    public void Bank_sell_Phone()
    {
        if(_hasMoneyMultiplier == true)
        {
            _uiManager.Phone--;
            _uiManager.UpdateCoins(80);
        }else if (_uiManager.Phone > 0)
        {
           _uiManager.Phone--;
           _uiManager.UpdateCoins(43);
        }
    }
    public void Bank_sell_Diamond()
    {
        if(_hasMoneyMultiplier == true)
        {
            _uiManager.Diamond--;
            _uiManager.UpdateCoins(130);
        }
       if (_uiManager.Diamond > 0)
       {
           _uiManager.Diamond--;
           _uiManager.UpdateCoins(100);
       }
    }
    public void Bank_sell_Tape()
    {
        if(_hasMoneyMultiplier == true)
        {
            _uiManager.Tape--;
            _uiManager.UpdateCoins(49);
        }else if(_uiManager.Tape > 0)
        {
            _uiManager.Tape--;
            _uiManager.UpdateCoins(25);
        }
    } 
    public void Time_PowerUp()
    {
        _uiManager._numberofminutes++;
    }
    public void Speed_PowerUP()
    {
        if(_uiManager.Coins >= 50)
        {
            _uiManager.Coins -= 50;
            _uiManager.UpdateCoins(_uiManager.Coins);
            _player._speed += 2;
        }
        else
        {
            Debug.Log("You don't have enough coins");
        }
      
    }
    public void Money_PowerUP()
    {
        if(_uiManager.Coins >= 300)
        {
            _uiManager.Coins -= 300;
            _hasMoneyMultiplier = true;
        }
        else
        {
            Debug.Log("You don't have enough coins");
        }
       
    }
    public void CreditsMenu()
    {
      _creditsMenu.SetActive(true);
    }
    public void HTPmenu()
    {
        _howToPlayMenu.SetActive(true);
    }
    public void ExitMenu()
    {
        _howToPlayMenu.SetActive(false);
        _creditsMenu.SetActive(false);
    }
    public void ExitStartMenu()
    {
        _startMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
