using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightStair : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //pointlight bool°ª Á¶Àý
        }
    }
}
