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
        // tag ���� �ӵ� ��ġ ���氪�� ���� �����ϱ����� ����
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
        // ������ġ������ õõ�� �̵���
        transform.position = transform.position + trapDown * Time.deltaTime;
    }
    void TrapOn()
    {
        //������ġ�� + 0.1f
        transform.position = transform.position + trapUp;
    }
    public void TrapMove_X()
    {
        //Ʈ�� �ڵ�ȭ
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
        //Ʈ�� �ڵ�ȭ
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
        //ȸ������ �����̴� �Լ� Z�� ���� ȸ���ϰԵ�����
        transform.localEulerAngles = transform.localEulerAngles + trapDown * Time.deltaTime;
    }
}
