using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject GameClear;
    public GameObject GameStart;
    public static Score Instance;
    public Text StartText;
    public Text scoreText;
    private int scoreNum = 0;
    public int bossHP = 100;


    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    void Start()
    {
        Invoke("StartGame", 1.0f);
        StartCoroutine("StartGameCount");
    }

    public void AddScore(int num)
    {
        scoreNum += num;
        scoreText.text = "점수 : "+scoreNum;
    }

    public void KillBoss()
    {
        bossHP -= 10;
        Debug.Log("현재 보스 HP는 "+bossHP);
    }

    void Update()
    {
        if(scoreNum > 1500)
        {
            GameClear.gameObject.SetActive(true);

            Invoke("NextGame", 2.0f);

            
        }
    }

    void StartGame()
    {
        //GameStart.gameObject.SetActive(false);
    }

    void NextGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator StartGameCount()
    {
        int i = 3;
        while (i > 0)
        {
            StartText.text = i.ToString();
            yield return new WaitForSeconds(1);
            i--;
            if (i == 0)
            {
                GameStart.gameObject.SetActive(false);
            }
        }
    }
}
