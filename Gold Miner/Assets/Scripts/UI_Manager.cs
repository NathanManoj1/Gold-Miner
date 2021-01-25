using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public int Coins;
    [SerializeField]
    private TextMeshProUGUI _coinText;
 
    void UpdateCoins(int amount)
    {
        Coins += amount;
        _coinText.text = "Coins: " + Coins;
    }
}
