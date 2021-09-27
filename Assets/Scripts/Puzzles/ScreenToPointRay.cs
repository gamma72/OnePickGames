using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToPointRay : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                switch (hit.collider.gameObject.tag)
                {
                    case "a":
                        if (Input.GetMouseButton(0))
                        {
                            hit.collider.gameObject.transform.position = new Vector3(-18, hit.point.y, hit.point.z);
                        }
                        break;
                    case "b":
                        if (Input.GetMouseButton(0))
                        {
                            hit.collider.gameObject.transform.position = new Vector3(-18, hit.point.y, hit.point.z);
                        }
                        break;
                    case "c":
                        if (Input.GetMouseButton(0))
                        {
                            hit.collider.gameObject.transform.position = new Vector3(-18, hit.point.y, hit.point.z);
                        }
                        break;
                }
            }
        }
    }
}
