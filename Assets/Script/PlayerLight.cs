using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    public Light lights;
    float curTime = 0;
    float coolTime = 5;
    public GameObject lightCollider;
    void Start()
    {
        lights = GetComponent<Light>();
        lightCollider = GameObject.Find("LightCollider");
    }


    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > coolTime)
        {
            if (lights.intensity >= 0)
            {
                lights.intensity -= Time.deltaTime;
            }
        }
        if (lights.intensity <= 0)
        {
            lightCollider.SetActive(false);
        }
        else
        {
            lightCollider.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Items")
        {
            Destroy(other.gameObject);
            lights.intensity += 1.5f;
        }
    }
}
