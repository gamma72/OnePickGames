using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeAttack : MonoBehaviour
{
    public Text timerText;
    public float time;
    public float msec;
    public float sec;
    public float min;

    public GameObject ClearPanel;
    void Start()
    {
        time = 60f; //���ѽð�
        StartCoroutine("StopWatch"); //�ڷ�ƾ ����
    }
    IEnumerator StopWatch()
    {
        while (true)
        {
            time -= Time.deltaTime; 
            msec = (int)((time - (int)time) * 100);
            sec = (int)(time % 60); 
            min = (int)(time / 60 % 60);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, msec); 

            if (time <= 0)
            {
                StopCoroutine("StopWatch");
                ClearPanel.SetActive(true); // Ŭ���� �ǳ� ����
                Time.timeScale = 0; //�Ͻ�����
                //SceneManager.LoadScene(0); //��Ʈ�ξ����� ��ȯ
            }

            yield return null;
        }
    }
}
