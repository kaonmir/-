using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;

    private bool isGameOver;

    [ContextMenu("Add Score")]
    public void AddScore(int scoreToAdd)
    {
        if (!isGameOver)
        {
            score += scoreToAdd;
            scoreText.text = score.ToString();
        }
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }
}
