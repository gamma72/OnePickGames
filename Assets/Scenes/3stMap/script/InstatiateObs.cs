using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateObs : MonoBehaviour
{
    public GameObject spwan_obj;
    Vector3 positionOrigin;
    
    void Start()
    {
        positionOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Instantiate(spwan_obj, new Vector3(0, 14, 43), Quaternion.identity);
            Instantiate(spwan_obj, positionOrigin, Quaternion.identity);
        }
    }
}
