using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLightMove : MonoBehaviour
{
    public bool LightMoves = false;
    public float enemyMoveRange;
    public float enemyMoveRange2;
    void Start()
    {

    }
    void Update()
    {
        if (LightMoves == false)
        {
            EnemyLightMoveMinus();
            if (transform.position.z < enemyMoveRange)
            {
                LightMoves = true;
            }
        }
        else if (LightMoves)
        {
            EnemyLightMovePlus();
            if (transform.position.z > enemyMoveRange2)
            {
                LightMoves = false;
            }
        }
    }
    public void EnemyLightMoveMinus()
    {
        transform.position = transform.position + new Vector3(0, 0, -1) * Time.deltaTime;
    }
    public void EnemyLightMovePlus()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
    }
}