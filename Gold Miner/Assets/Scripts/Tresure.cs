
using UnityEngine;

public class Tresure : MonoBehaviour
{
    UI_Manager _uiManager;
    Player _player;

  
    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
    

        if(collision.tag == "Player" )
        {
            switch (this.tag)
            {
                case "TV":
                   _uiManager.TV++; 
                    Destroy(this.gameObject, 1.5f);
                    break;
                case "Phone":
                 _uiManager. Phone++;
                    Destroy(this.gameObject, 2f);
                    break;
                case "Diamond":
                 _uiManager.Diamond++;
                    Destroy(this.gameObject, 4f);
                    break;
                case "Gold":
                    _uiManager.UpdateCoins(10);
                    Destroy(this.gameObject, 1);
                    break;
                case "Tape":
                   _uiManager.Tape++;
                    Destroy(this.gameObject, .5f);
                    break;


            }
         
        }
    }
}
