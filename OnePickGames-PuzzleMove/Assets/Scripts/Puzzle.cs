using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public bool puzzleOn = false;
    public float curTime = 0;
    public float coolTime = 3f;
    void Start()
    {

    }

    
    void Update()
    {
        
    }
    public void Puzzles()
    {
        if (Input.GetKey(KeyCode.E))
        {
            curTime += Time.deltaTime;
            if(curTime > coolTime)
            {
                curTime = 0;
                puzzleOn = true;
                Debug.Log("퍼즐 화면전환");
                gameObject.SetActive(false);
            }
        }
        else if (!Input.GetKey(KeyCode.E))
        {
            curTime = 0;
        }
    }
}
