using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    public float gameOverY;
    public GameObject ClearPanel;
    void Start()
    {
        
    }

    void Update()
    {
     if(transform.localPosition.y <gameOverY)
        {
            ClearPanel.SetActive(true); // ÆÇ³Ú ¶ç¿ì±â
            Time.timeScale = 0; //ÀÏ½ÃÁ¤Áö
        }
    }

    
}
