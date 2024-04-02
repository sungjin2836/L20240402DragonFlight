using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //��ũ���� �Ǵ� ��׶���
    public float scrollSpeed = 1f;
    [SerializeField]
    private Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;

    }

    void Update()
    {
        //������ ���͸��󿡼� ��������
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //���Ӱ� offset �ٲ��ֱ�
        //y�κа��� �ӵ��� ������ �����ؼ� ������

        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        // ���͸��� �����¿� �� �־���
        myMaterial.mainTextureOffset = newOffset;
    }
}
