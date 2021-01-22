using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shops : MonoBehaviour
{
    [SerializeField]
   private GameObject[] _Shop_Panels;
   public bool _ElectronicButton;
   public bool _BankButton;
   public bool _PowerUpShop;
   

    //each shop is a button if you click a button then it goes to the button manager then it comes here and in this script it enables the correct panel. 



    //if clicked on button then bool is true if bool is true and you are in the range (ontriggerstay) then panel is enabled;
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
  
}
