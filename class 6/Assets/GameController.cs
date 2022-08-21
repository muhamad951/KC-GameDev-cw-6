using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnLeft;
    public Transform spawnRight;

    public GameObject enemy;

    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0f, delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemy()
    {
        int randnum = Random.Range(1, 4); //1 or 2 or 3
        if (randnum == 1)
        {
            Instantiate(enemy, spawnLeft);
        }
        if (randnum == 2)
        {
            Instantiate(enemy, spawn);
        }
        else 
        {
            Instantiate(enemy, spawnLeft);
        }
    }
}
