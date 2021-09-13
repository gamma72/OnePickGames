using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleEscape : MonoBehaviour
{
    public GameObject exitBtn;
    Puzzle puzzle;
    public bool puzzleClear = false;

    void Start()
    {
        exitBtn = GameObject.Find("ExitBtn");
        puzzle = GameObject.FindGameObjectWithTag("Puzzle").GetComponent<Puzzle>();
    }
    
    
    void Update()
    {
        //퍼즐 클리어 조건 예시
        if (Input.GetKeyDown(KeyCode.F))
        {
            puzzleClear = true;
        }

        if (puzzleClear)
        {
            exitBtn.SetActive(true);
        }
        else
        {
            exitBtn.SetActive(false);
        }
    }
    public void ExitBtn()
    {
        if (puzzle.puzzleOn)
        {
            if (puzzleClear)
            {
                puzzle.puzzleOn = false;
                exitBtn.SetActive(false);
            }
        }
    }
}
