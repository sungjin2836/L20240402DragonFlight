using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    //�ڷᱸ��
    public List<GameObject> list = new List<GameObject>();

    public void SpawnEnemy()
    {
        //0~1 �� �� �ϳ�
        int random = Random.Range(0, list.Count);

        Instantiate(list[random],list[random].transform.position, Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2);
    }

    void Update()
    {
        
    }
}
