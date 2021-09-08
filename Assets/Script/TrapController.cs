using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    public bool trapOnOff = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(trapOnOff == true)
        {
            TrapMoveOff();
            if (transform.position.y <= 0)
            {
                trapOnOff = false;
            }
        }
        else if(trapOnOff == false)
        {
            TrapOn();
            if (transform.position.y > 1)
            {
                trapOnOff = true;
            }
        }
    }
    void TrapMoveOff()
    {
        transform.position = transform.position + new Vector3(0, -1, 0) * Time.deltaTime;
    }
    void TrapOn()
    {
        transform.position = transform.position + new Vector3(0, .1f, 0);
    }
}
