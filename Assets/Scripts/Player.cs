using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        //x�� �� ���� vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        Vector2 vector2 = new Vector2(distanceX, distanceY);

        transform.Translate(distanceX, distanceY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
