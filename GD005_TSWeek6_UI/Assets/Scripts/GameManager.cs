using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    float spawnRate;
    public List<string> easyWords;
    public List<string> hardWords;
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
