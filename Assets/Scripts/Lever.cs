using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject lever;
    public bool leverOn;
    public int inventoryCnt;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (leverOn)
        {
            lever.transform.localEulerAngles = transform.localEulerAngles + new Vector3(-20, 0, 0);
        }
        else if(leverOn == false)
        {
            lever.transform.localEulerAngles = transform.localEulerAngles + new Vector3(20, 0, 0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LeverBtn")
        {
            leverOn = true;
        }
    }
}
