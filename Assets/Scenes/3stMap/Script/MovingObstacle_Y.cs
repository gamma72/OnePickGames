using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle_Y : MonoBehaviour
{
    Vector3 positionOrigin;
    public float yRange;
    public float originY; //현재위치값
    void Start()
    {
        positionOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, originY + Mathf.PingPong(Time.time, yRange), transform.position.z);
    }
}
