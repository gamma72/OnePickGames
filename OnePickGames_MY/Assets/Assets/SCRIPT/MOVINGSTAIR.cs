using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVINGSTAIR : MonoBehaviour
{
    Vector3 positionOrigin;
    //public Transform Target;

    public float speed; //���ǵ� ����
    public float limitX; //x�� �Ѱ�
    void Start()
    {
        positionOrigin = transform.position;
    }

    void Update()
    {
        //position.x += 1 * Time.deltaTime;
        //transform.position = position;
        transform.Translate(-speed * Time.deltaTime, 0, 0);//�̵�
        if (transform.position.x < -limitX)
        {
            transform.position = positionOrigin; //ó�� ��ġ�� ��ȯ
        }
    }
}
