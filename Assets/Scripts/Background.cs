using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //스크롤이 되는 백그라운드
    public float scrollSpeed = 1f;
    [SerializeField]
    private Material myMaterial;

    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;

    }

    void Update()
    {
        //오프셋 머터리얼에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //새롭게 offset 바꿔주기
        //y부분값을 속도에 프레임 보정해서 더해줌

        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        // 머터리얼에 오프셋에 값 넣어줌
        myMaterial.mainTextureOffset = newOffset;
    }
}
