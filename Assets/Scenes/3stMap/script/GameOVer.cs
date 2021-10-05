using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOVer : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject ClearPanel;

    
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(playerController.itemCount >= 6) 
            {
                ClearPanel.SetActive(true); // Ŭ���� �ǳ� ����
                Time.timeScale = 0; //�Ͻ�����
            }
        }
    }
}
