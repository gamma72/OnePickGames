using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LASERBEAM : MonoBehaviour
{
    public float rotSpeed = 100f;
    //private LineRenderer lineRenderer;
    void Start()
    {
       // lineRenderer = GetComponent<LineRenderer>();
       // lineRenderer.SetPosition(0, transform.position);
       // lineRenderer.SetPosition(1, transform.position);
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag =="Player") //플레이어(태그)와 충돌하면_빛이??
        {
            Debug.Log("침입자 감지"); //효과음과 경보액션 처리
        }
    }
}
