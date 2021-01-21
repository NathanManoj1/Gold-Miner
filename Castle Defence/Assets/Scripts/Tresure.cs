
using UnityEngine;

public class Tresure : MonoBehaviour
{
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
           
            Destroy(this.gameObject, .5f);
        }
    }
}
