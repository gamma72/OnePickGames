using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    GameObject wallOpenBox;
    bool wallOpen = false;
    void Start()
    {
        wallOpenBox = GameObject.Find("WallOpen");
    }

    void Update()
    {
        if (wallOpen)
        {
            wallOpenBox.SetActive(false);
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
