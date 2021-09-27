using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);//+ 추가로 씬 처리
        }
    }
}
