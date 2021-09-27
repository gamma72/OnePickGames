using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleEscape : MonoBehaviour
{
    //public GameObject exitBtn;
    Puzzle puzzle;
    public bool puzzleClear = false;

    Vector3 mousePos;
    void Start()
    {
        //exitBtn = GameObject.Find("ExitBtn");
        puzzle = GameObject.FindGameObjectWithTag("Puzzle").GetComponent<Puzzle>();
    }

    void Update()
    {
        /*if (puzzle.nextPuzzle)
        {
            exitBtn.SetActive(true);
        }
        else
        {
            exitBtn.SetActive(false);
        }*/

        if (Input.GetKeyDown(KeyCode.F))
        {
            puzzleClear = true;
            if (puzzleClear)
            {
                puzzle.nextPuzzle = false;
                puzzle.gameObject.SetActive(false);
            }
        }
    }
    /*public void ExitBtn()
    {
        exitBtn.SetActive(false);
        puzzle.nextPuzzle = false;
    }*/
}
