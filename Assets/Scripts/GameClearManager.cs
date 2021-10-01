using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClearManager : MonoBehaviour
{
    public int gameClearCnt = 1;
    public Text keyText;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        keyText = GameObject.Find("KeyText").GetComponent<Text>();
    }

    void Update()
    {
        keyText.text = "Key : " + gameClearCnt;
    }
    public void GameSceneChange()
    {
        switch (gameClearCnt)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
            case 4:
                SceneManager.LoadScene(4);
                break;
        }
    }
}
