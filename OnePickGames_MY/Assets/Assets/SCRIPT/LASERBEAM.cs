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
       if(other.tag =="Player") //�÷��̾�(�±�)�� �浹�ϸ�_����??
        {
            Debug.Log("ħ���� ����"); //ȿ������ �溸�׼� ó��
        }
    }
}
