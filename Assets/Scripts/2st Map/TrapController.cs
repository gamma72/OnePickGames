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
    public void TrapMove_X()
    {
        //Ʈ�� �ڵ�ȭ
        if (trapOnOff == true)
        {
            TrapMovedeltaTime();

            //�����Ÿ� �̻� �Ѿ�°� ����
            if (transform.position.x <= trapPosMaxCnt)
            {
                trapOnOff = false;
            }
        }
        else if (trapOnOff == false)
        {
            TrapOn();

            //Ʈ���� ��ġ�� ������ Ʈ���ſ� �浹�� 
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
            if (transform.position.y > trapPosMaxCnt)
            {
                trapOnOff = true;
            }
        }
    }
    void TrapRotation()
    {
        //ȸ������ �����̴� �Լ� Z�� ���� ȸ���ϰԵ�����
        transform.localEulerAngles = transform.localEulerAngles + trapMove * Time.deltaTime;
    }
    void TrapMovedeltaTime()
    {
        // ������ġ������ õõ�� �̵���
        transform.position = transform.position + trapMove * Time.deltaTime;
    }
    void TrapOn()
    {
        //������ġ�� + 0.1f
        transform.position = transform.position + trapResetPos;
    }
}
