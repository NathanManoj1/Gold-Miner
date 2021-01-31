using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public int TV, Phone, Diamond, Tape;
    public int Coins;
    [SerializeField]
    private TextMeshProUGUI _coinText;
    [SerializeField]
    private TextMeshProUGUI _Timer;
    private int _numberofseconds;
    [SerializeField]
    public int _numberofminutes = 5;
    private Button_Manager _buttonManager;
    [SerializeField]
    private TextMeshProUGUI[] _SellPrices;
    GameManager _gameManager;
    [SerializeField]
    private GameObject _startMenu;

    private void Start()
    {
        _startMenu.SetActive(true);
        Time.timeScale = 0;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _numberofseconds = 60;
        StartCoroutine(Timer());
        _buttonManager = GameObject.Find("Canvas").GetComponent<Button_Manager>();

    }
    private void Update()
    {
        if(_buttonManager._hasMoneyMultiplier == true)
        {
            _SellPrices[0].text = "$150";
            _SellPrices[1].text = "$80";
            _SellPrices[2].text = "$40";
            _SellPrices[3].text = "$100";

        }
    }
    public void UpdateCoins(int amount)
    {
        Coins += amount;
        _coinText.text = "Coins: " + Coins;
    }
    private IEnumerator Timer()
    {
        for(int i = 0; i < 70; i++)
        {
            yield return new WaitForSeconds(1f);
            _numberofseconds--;
            if (_numberofseconds < 10)
            {
                _Timer.text = _numberofminutes + ":0" + _numberofseconds;
            }
            else
            {
                _Timer.text = _numberofminutes + ":" + _numberofseconds;
            }
            if (_numberofminutes == 0 && _numberofseconds == 0)
            {
                i = 100;
                _gameManager._Gameover = true;
            }
            else  if (_numberofseconds == 0)
            {
                _numberofseconds = 60;
                _numberofminutes--;
                i = 0;
            }
        }
        
    }
    
    
}
