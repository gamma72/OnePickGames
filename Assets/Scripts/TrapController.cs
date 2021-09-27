using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    public bool trapOnOff = true;
    public Vector3 trapDown = new Vector3();
    public Vector3 trapUp = new Vector3();
    public float trapCnt, trapCntPlus;
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
    void TrapMovedeltaTime()
    {
        // 현재위치값에서 천천히 이동함
        transform.position = transform.position + trapDown * Time.deltaTime;
    }
    void TrapOn()
    {
        //현재위치의 + 0.1f
        transform.position = transform.position + trapUp;
    }
    public void TrapMove_X()
    {
        //트랩 자동화
        if (trapOnOff == true)
        {
            TrapMovedeltaTime();
            if (transform.position.x <= trapCntPlus)
            {
                trapOnOff = false;
            }
        }
        else if (trapOnOff == false)
        {
            TrapOn();
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
            if (transform.position.y > trapCntPlus)
            {
                trapOnOff = true;
            }
        }
    }
    public void TrapRotation()
    {
        //회전값을 움직이는 함수 Z축 으로 회전하게되있음
        transform.localEulerAngles = transform.localEulerAngles + trapDown * Time.deltaTime;
    }
}
