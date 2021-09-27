using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    float curTime, coolTime = 3;

    [SerializeField]
    List<Material> colors;

    GameObject player;
    PlayerController playerC;

    MeshRenderer nowMesh;
    int nowNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerC = GameObject.Find("Player").GetComponent<PlayerController>();
        nowMesh = transform.GetChild(0).GetComponent<MeshRenderer>();
        nowMesh.material = colors[nowNum];
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;

        if(curTime >= coolTime)
        {
            curTime = 0;
            if(nowNum == colors.Count - 1)
            {
                nowNum = 0;
            }
            else
            {
                nowNum++;
            }
            nowMesh.material = colors[nowNum];
        }

        if (Vector3.Distance(player.transform.position, transform.position) <= 1.5f)
        {
            if(nowNum == 0)
            {
                if (playerC.isMove)
                {
                    playerC.resetPos = true;
                }
            }
        }
    }
}
