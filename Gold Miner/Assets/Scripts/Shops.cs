using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shops : MonoBehaviour
{
   [SerializeField]
   public GameObject[] _Shop_Panels;
   public bool _ElectronicButton;
   public bool _BankButton;
   public bool _PowerUpShop;
  
  




    private void Start()
    {

    }
    private void Update()
    {
     
     
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
           if(_ElectronicButton == true)
           {
                _Shop_Panels[0].SetActive(true);
           }
           else if(_BankButton == true)
           {
             
                _Shop_Panels[1].SetActive(true);
           }
           else if(_PowerUpShop == true)
           {
                _Shop_Panels[2].SetActive(true);
           }
          
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _ElectronicButton = false;
        _BankButton = false;
        _PowerUpShop = false;
    }
   
}
