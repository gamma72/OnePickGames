using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public bool nextPuzzle = false;
    public float curTime = 0;
    public float coolTime = 2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void NextPuzzle()
    {
        if (Input.GetKey(KeyCode.E))
        {
            curTime += Time.deltaTime;
            if(curTime > coolTime)
            {
                nextPuzzle = true;
            }
        }
        else if (!Input.GetKey(KeyCode.E))
        {
            curTime = 0;
        }
    }
}
