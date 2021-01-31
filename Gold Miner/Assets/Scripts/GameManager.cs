using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool _Gameover;
    [SerializeField]
    private AudioSource _GameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_Gameover == true)
        {
            StartCoroutine(gameOverSequence());
            
           
        }
    }
    private IEnumerator gameOverSequence()
    {
        _GameOver.enabled = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
