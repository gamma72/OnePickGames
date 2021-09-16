using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GenerateMaps : MonoBehaviour
{
    public Transform tilePrefab; //타일 프레팹
    public Vector2 mapSize; // 맵 사이즈

    [Range(0, 1)]
    public float outlinePercent; // 아웃라인 퍼센트

    public void GenerateMap()
    {
        string holderName = "Generated Map";

        if (transform.FindChild(holderName))
        {
            DestroyImmediate(transform.FindChild(holderName).gameObject);
        }

        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;

        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 tilePosition = new Vector3(-mapSize.x / 2 + 0.5f + x, 0, -mapSize.y / 2 + 0.5f + y);
                Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 0));
                newTile.parent = mapHolder;

                //크기 조정
                newTile.localScale = Vector3.one * (1 - outlinePercent);
            }
        }
    }
}
