using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameManager _gm;
    public string myWord;
    public TMP_Text mytext;
   
    

    private void Start()
    {
        
        
            _gm = GameObject.FindAnyObjectByType<GameManager>();
            myWord = _gm.words[Random.Range(0, _gm.words.Length)];
            mytext.text = myWord;
        
    }

    private void Update()
    {
        transform.Translate(Vector3.right * 3 * Time.deltaTime);

        if (transform.position.x >= 8.5f)
        {
            Destroy(gameObject);
            _gm.lives--;
        }

        if (_gm.input.text == myWord)
        {
            _gm.score++;
            _gm.input.text = string.Empty;
            Destroy(gameObject);
        }
    }

}