using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle_X : MonoBehaviour
{
    public float xRange;//이동범위
    //public float xSpeed;//이동속도
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, xRange), transform.position.y, transform.position.z);
    }
}
