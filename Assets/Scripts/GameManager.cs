using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
    public Text playerScore;
    public GameObject pnlGameOver;
    public Text gameOverScore;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            AudioManager.instance.Audio_EndGame();
            GameObject.Find("enemySpawner").GetComponent<EnemySpawner>().StopSpawning();
            gameOverScore.text = "Score : " + score.ToString();
            pnlGameOver.SetActive(true);
            playerScore.text = "";
        }
    }
    public void UpdateScore()
    {
        if(!gameOver)
        {
            score++;
            playerScore.text = score.ToString();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
