using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLightGet : MonoBehaviour
{
    bool moveOn = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (moveOn)
        {
            MoveMouse();
            if (transform.position.z >= 2)
            {
                Destroy(gameObject);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            moveOn = true;
        }
    }

    public void MoveMouse()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
    }
}
