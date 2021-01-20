
using UnityEngine;

public class Tresure : MonoBehaviour
{
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("This is called");
        if(collision.tag == "Player")
        {
            Debug.Log("Hello");
            Destroy(this.gameObject, .5f);
        }
    }
}
