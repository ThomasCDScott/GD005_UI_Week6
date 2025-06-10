using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    GameManager _gm;
    public string myWord;
    public TMP_Text mytext;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gm = GameObject.FindAnyObjectByType<GameManager>();
        myWord = _gm.easyWords[Random.Range(0, _gm.easyWords.Count)];
        mytext.text = myWord;
    }

    // Update is called once per frame
    void Update()
    {
        if (_gm.currentInput.text == myWord)
        {
            _gm.score++;
            _gm.currentInput.text = string.Empty;
            Destroy(gameObject);
        }
    }
}
