using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUIMaker: MonoBehaviour
{
   
    public Text itemCounter;
    public PlayerController playerController;

    AudioSource aud;
    // public AudioClip Achievement_01;
    public GameObject uiManager;
    void Start()
    {
        uiManager = GameObject.Find("UIManager");
        this.aud = GetComponent<AudioSource>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        itemCounter = GameObject.Find("CoinText").GetComponent<Text>();
    }

    void Update()
    {
        itemCounter.text = playerController.itemCount + "°³";
    }

   
}
