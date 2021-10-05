using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Scene_Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart() //재시작 함수
    {
        SceneManager.LoadScene(0);//3으로 바꾸기
    }
    public void GameClear()
    {
        SceneManager.LoadScene(4);//클리어 씬
    }
    public void Quit()
    {
        Application.Quit();
    }
}
