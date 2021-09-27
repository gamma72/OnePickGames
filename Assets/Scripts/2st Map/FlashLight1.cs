using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight1 : MonoBehaviour
{
    public GameObject player;
    bool getLight = false;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (getLight)
        {
            transform.position = player.transform.position + new Vector3(0.25f, .5f, 1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            getLight = true;
        }
    }
}
