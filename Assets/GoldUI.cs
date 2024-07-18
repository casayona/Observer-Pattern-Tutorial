using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int coinCount;


    private void OnEnable()
    {
        PlayerMovement.OnCoinCollected += PlayerMovement_OnCoinCollected;
        PlayerMovement.OnCoinCollected2 += PlayerMovement_OnCoinCollected2;
    }

    private void PlayerMovement_OnCoinCollected()
    {

        coinCount++;
        coinText.text = "Coin" + coinCount.ToString();
    }
    private void PlayerMovement_OnCoinCollected2()
    {

        coinCount += 5;
        coinText.text = "Coin" + coinCount.ToString();
    }

    private void OnDisable()
    {
        PlayerMovement.OnCoinCollected -= PlayerMovement_OnCoinCollected;
        PlayerMovement.OnCoinCollected2 -= PlayerMovement_OnCoinCollected2;
    }
}
