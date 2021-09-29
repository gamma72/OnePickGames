using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGrab : MonoBehaviour
{
    [SerializeField]
    GameObject obj;

    GameObject player;

    Rigidbody testRig;

    bool isGrab;

    void Start()
    {
        player = GameObject.Find("Player");
        
    }

    void Update()
    {
        float xpos = Input.GetAxis("Horizontal");

        if(xpos > 0)
        {
            transform.position = player.transform.position + new Vector3(0,.25f, 1.5f);
        }
        if(xpos < 0)
        {
            transform.position = player.transform.position - new Vector3(0, -.25f, 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if(obj == null)
            {
                isGrab = false;
            }
            else
            {
                isGrab = !isGrab;
            }
        }

        if (isGrab && obj != null)
        {
            testRig.MovePosition(transform.position);
            testRig.useGravity = true;
            testRig.isKinematic = true;
        }
        if (!isGrab && obj != null)
        {
            testRig.isKinematic = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isGrab)
        {
            return;
        }
        if(other.tag == "MoveObj")
        {
            obj = other.gameObject;
            testRig = obj.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (isGrab)
        {
            return;
        }
        if (other.tag == "MoveObj")
        {
            obj = null;
            testRig = null;
        }
    }
}
