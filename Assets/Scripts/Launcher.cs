using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Launcher : MonoBehaviour
{
    public GameObject bullet; // �̻��� ������ ������ ����
    public GameObject Ult;
    [SerializeField] GameObject container;
    public ParticleSystem fire;

    public int score = 0;

    public GameObject ScoreText;

    public float shootSpeed = 0.1f;

    void Start()
    {
        //("�Լ��̸�", �ʱ������ð�, ������ �ð�)
        InvokeRepeating("Shoot", 3.0f, shootSpeed);

        fire = Instantiate(fire);
        fire.gameObject.SetActive(false);
    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        var item = Instantiate(bullet, transform.position, Quaternion.identity);
        item.transform.parent = container.transform;
        //���� �÷���
        //SoundManager.instance.PlayerSound();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UltFire();
            //Destroy(Ult, 1.0f);
        }
    }

    void UltFire()
    {
        //Debug.Log(transform.position);
        var item = Instantiate(Ult, transform.position, Quaternion.identity);

        StartCoroutine(EffectOn());
        //Invoke("StopFire",2);
        Destroy(item, 2);
        
    }

    IEnumerator EffectOn()
    {
        fire.gameObject.SetActive(true);
        fire.Play();
        yield return new WaitForSeconds(2);
        fire.Stop();
        fire.gameObject.SetActive(false);

    }
    void StopFire()
    {
        //fire.Stop();
    }

    



}
