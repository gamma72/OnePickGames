using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle_X : MonoBehaviour
{
    public float xRange;//�̵�����
    public float originX; //������ġ��
    //public float xSpeed;//�̵��ӵ�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(originX + Mathf.PingPong(Time.time, xRange), transform.position.y, transform.position.z);
    }
}
