using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public bool enableSpawn = false;
    [SerializeField] GameObject container;
    public GameObject enemy;

    public GameObject Boss;

    private float bossSpawnTime = 0;

    public float currentTime = 0;

    public float createTime = 2;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5, 0.5f);
    }

    void Update()
    {
        bossSpawnTime += Time.deltaTime;
        if (bossSpawnTime > 10.0f)
        {
            SpawnBoss();

            bossSpawnTime -= 1000;
        }




        //currentTime = currentTime + Time.deltaTime;

        //if(currentTime > createTime)
        //{

        //float random = 0;

        //random = Random.Range(-250, 250)/100;
        //    Debug.Log(random);

        //float x = random;

        //GameObject smallEnemy = Instantiate(enemy);

        //smallEnemy.transform.position = new Vector2(x, 5);

        //    currentTime = 0;
        //}
    }

    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);

        if (enableSpawn)
        {
            //적을 생성한다.randomX랜덤한 x값
            var item = Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
            item.transform.parent = this.transform;
            //Instantiate(enemy).transform.position = new Vector2(randomX, 5);
        }
    }

    public void SpawnBoss()
    {
        Instantiate(Boss, new Vector3(0, transform.position.y, 0f), Quaternion.identity);
    }



}
