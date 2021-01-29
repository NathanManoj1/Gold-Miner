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
    private int _numberofminutes = 5;

    private void Start()
    {
        _numberofseconds = 60;
        StartCoroutine(Timer());
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
                Debug.Log("all done");
                i = 100;
                i = 100;
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
