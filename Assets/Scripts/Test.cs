using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //자료구조
    public List<GameObject> list = new List<GameObject>();
    public GameObject enemy;
    private float spawnX = -3.0f;
    public int maxSpawn = 5;
    private int spawnCount = 0;

    void Start()
    {

        Invoke("SpawnFirstEnemy", 1.0f);

        InvokeRepeating("SpawnEnemy", 3, 1.0f);

    }

    void SpawnFirstEnemy()
    {
        for (int i = 0; i < 5; i++)
        {

            spawnX += 1.0f;
            Instantiate(enemy, new Vector3(spawnX, transform.position.y, 0f), Quaternion.identity);
            Debug.Log(i + "번째 SpawnFirstEnemy   ");
            list.Add(enemy);
        }
        spawnX = -3.0f;
    }

    void SpawnEnemy()
    {
        if(spawnCount < 3)
        {

        for(int i = 0;i < list.Count;i++)
        {
            spawnX += 1.0f;
            Instantiate(list[i], new Vector3(spawnX, transform.position.y, 0f), Quaternion.identity);
        }
        spawnCount++;
            Debug.Log(spawnCount);
        spawnX = -3.0f;
        }
        

    }
}
