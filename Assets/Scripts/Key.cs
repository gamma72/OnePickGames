using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    GameObject key;
    GameClearManager gameClearManager;
    void Start()
    {
        key = GameObject.Find("Key");
        gameClearManager = GameObject.FindGameObjectWithTag("GameClearManager").GetComponent<GameClearManager>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ClearDoor")
        {
            Destroy(key);
            gameClearManager.gameClearCnt += 1;
            gameClearManager.GameSceneChange();
        }
    }
}
