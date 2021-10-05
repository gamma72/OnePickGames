using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEscape : MonoBehaviour
{
    public Transform Target;
    public int yAngle;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = Target.position; // �ε��� ��ü�� Ÿ���� ��ġ�� ������.
            other.transform.rotation = Quaternion.Euler(0, yAngle, 0);//y��ȸ��
        }
    }
}
