using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    PlayerController2D playerController2D;
    bool spawnPoint = false;
    void Start()
    {
        playerController2D = GameObject.Find("Player").GetComponent<PlayerController2D>();
    }

    
    void Update()
    {
        if (spawnPoint)
        {
            playerController2D.ResetPos();
            spawnPoint = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            spawnPoint = true;
        }
    }
}
