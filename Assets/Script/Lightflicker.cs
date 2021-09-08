using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightflicker : MonoBehaviour
{
    Material flickerMate;
    bool flickerOn = false;
    Light flicker;
    float curTime = 0;
    float coolTime = 0.3f;
    void Start()
    {
        flicker = GameObject.FindGameObjectWithTag("Flicker").GetComponent<Light>();
        
    }

    void Update()
    {
        if (flickerOn == false)
        {
            curTime += Time.deltaTime;
            if(curTime > coolTime)
            {
                curTime = 0;
                FlickerPlus();
                if (flicker.range >= 10)
                {
                    flickerOn = true;
                }
            }
        }
        else if(flickerOn == true)
        {
            curTime += Time.deltaTime;
            if(curTime > coolTime)
            {
                curTime = 0;
                FlickerMinus();
                if (flicker.range <= 5)
                {
                    flickerOn = false;
                }
            }
        }
    }

    public void FlickerPlus()
    {
        flicker.range += 5;
    }
    public void FlickerMinus()
    {
        flicker.range -= 5;
    }
}
