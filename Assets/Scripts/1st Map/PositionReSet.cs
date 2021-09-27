using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReSet : MonoBehaviour
{
    [SerializeField]
    Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPos();
        }
    }

    public void ResetPos()
    {
        transform.position = spawnPoint.position;
    }
}
