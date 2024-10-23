using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] int score = 0;
    public void GameScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
