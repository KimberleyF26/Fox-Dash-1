using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get;set;}

    public TextMeshProUGUI coinsText;
     public TextMeshProUGUI highScoreText;


    private int coinsCollected = 0;
    

    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(Instance);
        }
        
        Instance = this;
        DontDestroyOnLoad(Instance);
    }

    private void Start()
    {
        UpdateCoinUIText();
        UpdateHighestScoreCoinUIText();
    }


    public void CollectCoin()
    {
        coinsCollected++;

        int highScore = PlayerPrefs.GetInt("highScore",0);
        if(coinsCollected > highScore)
        {
            PlayerPrefs.SetInt("highScore",coinsCollected);

        }


        //Update UI texts
         UpdateCoinUIText();
         UpdateHighestScoreCoinUIText();
    }

    public void ResetCoins()
    {
        coinsCollected = 0;
         UpdateCoinUIText();
         UpdateHighestScoreCoinUIText();
    }

    public void UpdateCoinUIText()
    {
        int numberOfCoins = GetCoinsCollected();
        coinsText.text = numberOfCoins.ToString();
    }

    public void UpdateHighestScoreCoinUIText()
    {
        int highScore = PlayerPrefs.GetInt("highScore",0);
    
        highScoreText.text = highScore.ToString();
    }

    public int GetCoinsCollected()
    {
        return coinsCollected;
    }

   /*public void EndGame()
    {
        Debug.Log("Game Over");
    }*/
}
