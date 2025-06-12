using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    float spawnRate = 1;
    public List<string> easyWords;
    public List<string> normalWords;
    public List<string> hardWords;
    public List<string> extreamWords;

    public TMP_InputField currentInput;
    public int score;
    public TextMeshProUGUI scoreText;
    public int lives;
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

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator SpawnTargets()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            
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
        StartCoroutine(SpawnTargets());
        score = 0;
        lives = 0;

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
