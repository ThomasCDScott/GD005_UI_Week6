using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string[] words;
    public TMP_InputField input;
    public int score, lives;
    public GameObject Enemy;

 
    private float spawnRate = 1;
    public List<string> easyWords;
    public List<string> normalWords;
    public List<string> hardWords;
    

    public TMP_InputField currentInput;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject gameOverUI, titleUI;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        isGameActive = true;
        UpdateScore(0);
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(Enemy, new Vector3(-10, Random.Range(0, 5), 0), Quaternion.identity);

        }
    }

    public void UpdateScore(int scoretoAdd)
    {
        score += scoretoAdd;

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void StartGame(int difficulty)
    {
        StartCoroutine(SpawnEnemy());
        score = 0;
        lives = 5;

        scoreText.text = "Score" + score;
        livesText.text = "Lives" + lives;

        titleUI.SetActive(false);
        spawnRate /= difficulty;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}