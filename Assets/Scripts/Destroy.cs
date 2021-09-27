using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Light light;
    GameObject wallOpenBox;
    bool wallOpen = false;
    void Start()
    {
        light = GameObject.Find("Light").GetComponent<Light>();
        wallOpenBox = GameObject.Find("WallOpen");
    }

    void Update()
    {
        if (wallOpen)
        {
            wallOpenBox.SetActive(false);
            light.intensity -= Time.deltaTime;
            if(light.intensity <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            wallOpen = true;
        }
    }
}
