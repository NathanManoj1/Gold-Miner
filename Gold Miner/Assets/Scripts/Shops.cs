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
    public GameObject[] Shop_Buttons;
   

    private void Update()
    {
       
            if (_ElectronicButton == true)
            {
                for (int i = 0; i < Shop_Buttons.Length; i++)
                {
                    Shop_Buttons[i].SetActive(false);
                }
                _Shop_Panels[0].SetActive(true);
            }
            else if (_BankButton == true)
            {
                for (int i = 0; i < Shop_Buttons.Length; i++)
                {
                    Shop_Buttons[i].SetActive(false);
                }
                _Shop_Panels[1].SetActive(true);
            }
            else if (_PowerUpShop == true)
            {
                for (int i = 0; i < Shop_Buttons.Length; i++)
                {
                    Shop_Buttons[i].SetActive(false);
                }
                _Shop_Panels[2].SetActive(true);
            }
        
    }
  
   
   
}
