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
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면 밖으로 나가면 안보일 경우 호출이 되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }

    //트리거
    //콜리전
    //enter 1번 들어올때
    //stay 계속 충돌 범위 안에
    //exit 충돌이 끝날 때 나가질 때 1번

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(effect, this.transform.position, Quaternion.identity);

            //Destroy(effect, 1);
            Score.Instance.AddScore(10);
            //SoundManager.instance.SoundDie();

            Debug.Log(gameObject.name);
            //적 지우기
            Destroy(collision.gameObject);
            //나 자신 지우기

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
                //적 지우기
                Destroy(collision.gameObject);
                //나 자신 지우기
                Score.Instance.AddScore(1000);
                //Destroy(effect, 2.0f);
            }
        }
    }
}
