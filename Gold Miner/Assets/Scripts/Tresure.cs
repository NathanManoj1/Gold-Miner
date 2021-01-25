
using UnityEngine;

public class Tresure : MonoBehaviour
{
    UI_Manager _uiManager;
    public int TV, Phone, Diamond, Tape;
    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
      //objective: Make a system where it reconizes what item this is and keep track of how many of the item is there;
      // make int for each item;
      //how to filter the items;

        if(collision.tag == "Player")
        {
            switch (this.tag)
            {
                case "TV":
                    TV++; 
                    Destroy(this.gameObject);
                    break;
                case "Phone":
                    Phone++;
                    Destroy(this.gameObject);
                    break;
                case "Diamond":
                    Diamond++;
                    Destroy(this.gameObject);
                    break;
                case "Gold":
                    _uiManager.UpdateCoins(10);
                    Destroy(this.gameObject);
                    break;
                case "Tape":
                     Tape++;
                    Destroy(this.gameObject);
                    break;


            }
         
        }
    }
}
