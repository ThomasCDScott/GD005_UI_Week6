using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    float spawnRate = 1;
    public List<string> easyWords;
    public List<string> hardWords;

    public TMP_InputField currentInput;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnTargets());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator SpawnTargets()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            spawnRate = Random.Range(0, 2);
        }
    }
}
