
using UnityEngine;

public class Tresure : MonoBehaviour
{
    public string[] items;
    public int TV, Phone, Diamond;
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
                    Debug.Log("This is a TV");
                    break;
                case "Phone":
                    Debug.Log("This is a Phone");
                    break;
                case "Diamond":
                    Debug.Log("This is a diamond");
                    break;

            }
         
        }
    }
}
