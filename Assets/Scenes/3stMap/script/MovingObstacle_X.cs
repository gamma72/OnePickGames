using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle_X : MonoBehaviour
{
    public float xRange;//이동범위
    public float originX; //현재위치값
    //public float xSpeed;//이동속도
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(originX + Mathf.PingPong(Time.time, xRange), transform.position.y, transform.position.z);
    }
}
