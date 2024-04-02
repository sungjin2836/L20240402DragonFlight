using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance; //자기자신을 변수로 만듬
    //어디서든 가져다가 사용할 수가 있다

    AudioSource myAudio; //AudioSource 컴포넌트를 변수로 담음

    public AudioClip soundExplosion; //재생할 소리를 변수로 담음
    public AudioClip soundDie; //죽는 사운드



    //public SoundManager()
    //{
    //    instance = this;
    //}

    private void Awake()
    {
        if (SoundManager.instance != null) //instance가 비어있는지 검사
        {
            instance = this; //자기참조객체
        }
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); //AudioSource컴포넌트 가져오기

    }

    public void PlayerSound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }


    void Update()
    {
        
    }
}
