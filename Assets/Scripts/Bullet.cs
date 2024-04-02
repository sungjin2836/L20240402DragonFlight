using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public GameObject effect;
    public GameObject effect2;
    
    void Start()    
    {
    }


    void Update()
    {
        //y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //ȭ�� ������ ������ �Ⱥ��� ��� ȣ���� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        //�̻��� �����
        Destroy(gameObject);
    }

    //Ʈ����
    //�ݸ���
    //enter 1�� ���ö�
    //stay ��� �浹 ���� �ȿ�
    //exit �浹�� ���� �� ������ �� 1��

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(effect, this.transform.position, Quaternion.identity);

            //Destroy(effect, 1);
            Score.Instance.AddScore(10);
            //SoundManager.instance.SoundDie();

            Debug.Log(gameObject.name);
            //�� �����
            Destroy(collision.gameObject);
            //�� �ڽ� �����

            if (this.gameObject.CompareTag("Ult"))
            {
                Destroy(gameObject, 3.0f);
                Destroy(collision.gameObject);
            }
            else
            {
            Destroy(gameObject);
            }
            //Destroy(effect);
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            Instantiate(effect, this.transform.position, Quaternion.identity);
            //Destroy(effect, 0.5f);
            Score.Instance.KillBoss();
            Destroy(gameObject);
            if (Score.Instance.bossHP < 0)
            {
            Instantiate(effect2, this.transform.position, Quaternion.identity);
            //Destroy(effect2, 2.0f);
                //�� �����
                Destroy(collision.gameObject);
                //�� �ڽ� �����
                Score.Instance.AddScore(1000);
                //Destroy(effect, 2.0f);
            }
        }
    }
}
