using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    public bool trapOnOff = true;
    public Vector3 trapMove = new Vector3();
    public Vector3 trapResetPos = new Vector3();
    public float trapCnt;
    public float trapPosMaxCnt;
    void Start()
    {

    }
    void Update()
    {
        // tag 별로 속도 위치 변경값을 따로 변경하기위해 나눔
        switch (gameObject.tag)
        {
            case "XMove":
                TrapMove_X();
                break;
            case "YMove":
                TrapMove_Y();
                break;
            case "RotationBox":
                TrapRotation();
                break;
        }
    }
    public void TrapMove_X()
    {
        //트랩 자동화
        if (trapOnOff == true)
        {
            TrapMovedeltaTime();

            //일정거리 이상 넘어가는걸 방지
            if (transform.position.x <= trapPosMaxCnt)
            {
                trapOnOff = false;
            }
        }
        else if (trapOnOff == false)
        {
            TrapOn();

            //트랩의 위치를 변경해 트리거와 충돌을 
            if (transform.position.x > trapCnt)
            {
                trapOnOff = true;
            }
        }
    }
    public void TrapMove_Y()
    {
        //트랩 자동화
        if (trapOnOff == true)
        {
            TrapMovedeltaTime();
            if (transform.position.y <= trapCnt)
            {
                trapOnOff = false;
            }
        }
        else if (trapOnOff == false)
        {
            TrapOn();
            if (transform.position.y > trapPosMaxCnt)
            {
                trapOnOff = true;
            }
        }
    }
    void TrapRotation()
    {
        //회전값을 움직이는 함수 Z축 으로 회전하게되있음
        transform.localEulerAngles = transform.localEulerAngles + trapMove * Time.deltaTime;
    }
    void TrapMovedeltaTime()
    {
        // 현재위치값에서 천천히 이동함
        transform.position = transform.position + trapMove * Time.deltaTime;
    }
    void TrapOn()
    {
        //현재위치의 + 0.1f
        transform.position = transform.position + trapResetPos;
    }
}
