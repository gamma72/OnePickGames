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

    public void Restart() //����� �Լ�
    {
        SceneManager.LoadScene(0);//3���� �ٲٱ�
    }
    public void GameClear()
    {
        SceneManager.LoadScene(4);//Ŭ���� ��
    }
    public void Quit()
    {
        Application.Quit();
    }
}
