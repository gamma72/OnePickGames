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
                ClearPanel.SetActive(true); // 클리어 판넬 띄우기
                Time.timeScale = 0; //일시정지
            }
        }
    }
}
