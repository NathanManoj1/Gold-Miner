using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player _player;
    public bool _buttonClicked = true;
    Button_Manager _buttonManager;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _buttonManager = GameObject.Find("Canvas").GetComponent<Button_Manager>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            
            if(_buttonClicked == true)
            {
                Destroy(this.gameObject, _player._PowerOfPickaxe);
                for (var i = 0; i < _buttonManager._ground.Length; i++)
                {
                    _buttonManager._ground[i]._buttonClicked = false;

                }
               
            }
           
        }
    }
  
    
}
