using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOver;

    private int score;

    public static GameController instance;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 1;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
