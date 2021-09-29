using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject door;
    public bool enemyMove = false;
    public Vector3 enemyPos = new Vector3(0, 0, 0);
    void Start()
    {
        
    }


    void Update()
    {
        if (enemyMove)
        {
            transform.position = transform.position + enemyPos * Time.deltaTime;
            Destroy(gameObject, 3);
            Destroy(door, 2);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            enemyMove = true;
        }
        if (other.gameObject.tag == "Player")
        {
            //플레이어 hp -1
        }
    }
}
