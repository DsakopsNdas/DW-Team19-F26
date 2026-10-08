using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DresserPuzzleManager : MonoBehaviour
{
    public int[] inputtedSigils = new int[4];
    public int inputtedSigilCount = 0;

    public GameObject[] crystals = new GameObject[4];

    public string potion;

    public PuzzleOpen puzzleOpen;

    public GameObject dresserComplete;
    public PuzzleOpen dresserButtonScript;

    private void Start()
    {
        puzzleOpen = GetComponent<PuzzleOpen>();
    }

    public void Submit()
    {
        if (inputtedSigils[0] == 1 &&
            inputtedSigils[1] == 3 &&
            inputtedSigils[2] == 4 &&
            inputtedSigils[3] == 2)
        {
            crystals[0].SetActive(true);
        }
        else if (inputtedSigils[0] == 3 &&
            inputtedSigils[1] == 2 &&
            inputtedSigils[2] == 1 &&
            inputtedSigils[3] == 4)
        {
            crystals[1].SetActive(true);
        }
        else if (inputtedSigils[0] == 4 &&
            inputtedSigils[1] == 1 &&
            inputtedSigils[2] == 2 &&
            inputtedSigils[3] == 3)
        {
            crystals[2].SetActive(true);
        }
        else if (inputtedSigils[0] == 2 &&
            inputtedSigils[1] == 4 &&
            inputtedSigils[2] == 3 &&
            inputtedSigils[3] == 1)
        {
            crystals[3].SetActive(true);
        }
        else return;

        puzzleOpen.ActivatePuzzle();
        dresserButtonScript.targetPuzzle = dresserComplete;
    }

    public void ResetSigils()
    {
        Array.Clear(inputtedSigils, 0, inputtedSigils.Length);
        inputtedSigilCount = 0;
    }
}
