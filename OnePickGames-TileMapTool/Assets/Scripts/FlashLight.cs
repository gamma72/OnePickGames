using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public bool flashLightOnOff = false;
    public GameObject flashLight;
    public int lightCnt = 0;

    public bool myStonOnOff = false;
    public GameObject mySton;

    public bool isTriggerOnOff;

    public GameObject player;
    Rigidbody rigidSton;
    public bool rigidisG = false;
    void Start()
    {
        rigidSton = GameObject.Find("Ston").GetComponent<Rigidbody>();
    }
    void Update()
    {
        //��ġ ����
        if (myStonOnOff)
        {
            mySton.transform.position = player.transform.position + new Vector3(0, 2, 1.5f);
        }
        
        //��ġ���� true / false
        if (Input.GetKeyDown(KeyCode.E) && myStonOnOff == false && isTriggerOnOff == true)
        {
            myStonOnOff = true;
            rigidSton.useGravity = false;
        }
        
        else if (Input.GetKeyDown(KeyCode.E) && myStonOnOff == true && isTriggerOnOff == true)
        {
            rigidSton.useGravity = true;
            myStonOnOff = false;
        }
        
        // useGravity Wall �� ������ ��
        if (rigidisG)
        {
            rigidSton.useGravity = false;
        }
        else if(rigidisG == true)
        {
            rigidSton.useGravity = true;
        }

        //�÷��� ����Ʈ OnOff
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (lightCnt == 0)
            {
                lightCnt += 1;
                flashLightOnOff = true;
                flashLight.SetActive(true);
            }
            else if (lightCnt == 1)
            {
                lightCnt -= 1;
                flashLightOnOff = false;
                flashLight.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MySton")
        {
            isTriggerOnOff = true;
        }
        else
        {
            isTriggerOnOff = false;
        }

        //Wall Ʈ����äũ
        if(other.gameObject.tag == "Wall")
        {
            rigidisG = true;
        }
        else
        {
            rigidisG = false;
        }
    }
}
