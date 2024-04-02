using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        //x쪽 값 설정 vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        Vector2 vector2 = new Vector2(distanceX, distanceY);

        transform.Translate(distanceX, distanceY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
