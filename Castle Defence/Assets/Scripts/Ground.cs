using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                
                Destroy(this.gameObject, _player._PowerOfPickaxe);
            }
          
        }
    }

    
}
