using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVINGSTAIR : MonoBehaviour
{
    Vector3 positionOrigin;
    //public Transform Target;

    public float speed; //스피드 조절
    public float limitX; //x값 한계
    void Start()
    {
        positionOrigin = transform.position;
    }

    void Update()
    {
        //position.x += 1 * Time.deltaTime;
        //transform.position = position;
        transform.Translate(-speed * Time.deltaTime, 0, 0);//이동
        if (transform.position.x < -limitX)
        {
            transform.position = positionOrigin; //처음 위치로 반환
        }
    }
}
