using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallUp : MonoBehaviour
{
    public int cnt = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(cnt == 1)
            {
                cnt++;
                transform.localEulerAngles = new Vector3(0, -30, 0);
                transform.position = transform.position + new Vector3(0, 0.75f, 0);
            }
        }
    }
}
