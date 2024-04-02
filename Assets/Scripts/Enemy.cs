using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //움직일 속도를 지정해줌

    public float moveSpeed = 1.3f;
    
    void Start()
    {
        
    }

    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;

        transform.Translate(0, -distanceY, 0);
    }

    private void OnBecameVisible()
    {

    }

    //화면 밖으로 나가면 카메라에서 안보이면
    private void OnBecameInvisible()
    {
        Destroy(gameObject); // 객체를 삭제
    }
}
