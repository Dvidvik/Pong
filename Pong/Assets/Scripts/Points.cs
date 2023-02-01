using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

    public int pointsToWin;

    int scorePlayer1 = 0;
    int scorePlayer2 = 0;


    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = player1Text.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI uiScorePlayer2 = player2Text.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = scorePlayer1.ToString();
        uiScorePlayer2.text = scorePlayer2.ToString();
    }



    public void IncreasePointsPlayer1()
    {
        scorePlayer1++;
        

        if(scorePlayer1 == pointsToWin)
        {
            scorePlayer1 = 0;
            MoveToGameOver();
        }
    }





    public void IncreasePointsPlayer2()
    {
        scorePlayer2++;


        if (scorePlayer2 == pointsToWin)
        {
            scorePlayer2 = 0;
            MoveToGameOver();
        }
    }



    public void MoveToGameOver()
    {
        //SceneManager.LoadScene("GameOver");
    }



}
