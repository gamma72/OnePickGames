using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interaction : MonoBehaviour
{
    public Vector3 playerPos;
    bool playerCollider = false;
    public Puzzle puzzle;
    public GameObject puzzleGame;

    void Start()
    {
        puzzle = GameObject.FindGameObjectWithTag("Puzzle").GetComponent<Puzzle>();
        puzzleGame = GameObject.FindGameObjectWithTag("Puzzle");
    }


    void Update()
    {
        if (playerCollider)
        {
            puzzle.NextPuzzle();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerPos = other.gameObject.transform.position;
            playerCollider = true;
        }
        else
        {
            playerCollider = false;
        }
    }
}
