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
            ClearPanel.SetActive(true); // �ǳ� ����
            Time.timeScale = 0; //�Ͻ�����
        }
    }

    
}
