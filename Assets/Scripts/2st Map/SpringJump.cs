using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJump : MonoBehaviour
{
    PlayerController2D playerController2D;
    void Start()
    {
        playerController2D = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController2D>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerController2D.jumps = true;
        }
    }
}
