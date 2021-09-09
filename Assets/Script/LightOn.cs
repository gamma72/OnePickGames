using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject[] lightObject;
    public float curTime = 0;
    public float coolTime = 0.5f;
    public GameObject missionClear;
    void Start()
    {
        //lightObject = new GameObject[3];
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LightCollider")
        {
            lightObject[0].SetActive(true);
            lightObject[1].SetActive(true);
            lightObject[2].SetActive(true);
            missionClear.SetActive(false);
        }
    }
}
