using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUIMaker: MonoBehaviour
{
    public int playerHp = 5;
    public int playerMaxHp = 5;
    public int itemCount = 0;
    public bool isDead = false;

    AudioSource aud;
    // public AudioClip Achievement_01;
    public GameObject uiManager;
    void Start()
    {
        uiManager = GameObject.Find("UIManager");
        this.aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //CameraShake();
            playerHp--;

            if (playerHp <= 0) 
            {
                SceneManager.LoadScene(0);
            }

        }
        if (other.gameObject.tag == "Item")
        {
            //this.aud.PlayOneShot(this.Achievement_01);
            itemCount++;
        }
        
    }
}
