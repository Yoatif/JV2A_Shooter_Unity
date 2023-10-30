using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    [SerializeField] public int playerScore = 0;
    public TextMeshProUGUI scorePlayer;

    public void addScore(int plus)
    {
        playerScore += plus;
        scorePlayer.text = playerScore.ToString();
    }

    public int getScore()
    {
        return playerScore;
    }

}
