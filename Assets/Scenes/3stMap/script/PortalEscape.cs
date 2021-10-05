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
            other.transform.position = Target.position; // ºÎµúÈù °´Ã¼¸¦ Å¸°ÙÀÇ À§Ä¡·Î º¸³½´Ù.
            other.transform.rotation = Quaternion.Euler(0, yAngle, 0);//y°ªÈ¸Àü
        }
    }
}
