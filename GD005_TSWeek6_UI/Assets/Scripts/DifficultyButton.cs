using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    Button difficultyButton;
    GameManager gameManager;
    public int difficulty = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        difficultyButton = GetComponent<Button>();
        //When the button is clicked this will make sure it is listening to the function.
        difficultyButton.onClick.AddListener(setDifficulty);

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void setDifficulty()
    {
        gameManager.StartGame(difficulty);
        
    }
}
