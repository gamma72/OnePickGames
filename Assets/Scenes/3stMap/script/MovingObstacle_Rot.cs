using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle_Rot: MonoBehaviour
{
    Vector3 positionOrigin;
    public float speed; 
    public float limitX;
    public int rotSpeed = 50;
    void Start()
    {
        positionOrigin = transform.position;

    }

    void Update()
    {
    transform.Translate(-speed * Time.deltaTime, 0, 0);//이동
    transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));

        if (transform.position.x < -limitX)
    {
        transform.position = positionOrigin; //처음 위치로 반환
    }
         
    }
}
