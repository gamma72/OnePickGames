using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeAttack : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float time;
    public float msec;
    public float sec;
    public float min;
    void Start()
    {
        time = 60f; //제한시간
        StartCoroutine("StopWatch"); //코루틴 실행
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
               // SceneManager.LoadScene(0); 
            }

            yield return null;
        }
    }
}
