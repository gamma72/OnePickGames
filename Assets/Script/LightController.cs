using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light lightRange;
    void Start()
    {
        lightRange = GameObject.FindGameObjectWithTag("LightRange").GetComponent<Light>();
    }

    void Update()
    {
        lightRange.intensity -= Time.deltaTime;
    }
}
