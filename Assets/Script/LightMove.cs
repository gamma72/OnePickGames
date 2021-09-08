using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    public bool LightMoves = false;
    public float moveRange;
    public float moveRange2;
    void Start()
    {
        
    }
    void Update()
    {
        if (LightMoves == false)
        {
            LightMoveMinus();
            if (transform.position.x < moveRange)
            {
                LightMoves = true;
            }
        }
        else if(LightMoves)
        {
            LightMovePlus();
            if(transform.position.x > moveRange2)
            {
                LightMoves = false;
            }
        }
    }
    public void LightMoveMinus()
    {
        transform.position = transform.position + new Vector3(-1, 0, 0) * Time.deltaTime;
    }
    public void LightMovePlus()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime;
    }
}
