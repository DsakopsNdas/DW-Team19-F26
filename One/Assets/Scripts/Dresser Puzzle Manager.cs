using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DresserPuzzleManager : MonoBehaviour
{
    public int[] inputtedSigils = new int[4];
    public int inputtedSigilCount = 0;

    public string potion;

    public PuzzleOpen puzzleOpen;

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
            potion = "burn";
        }
        else if (inputtedSigils[0] == 3 &&
            inputtedSigils[1] == 2 &&
            inputtedSigils[2] == 1 &&
            inputtedSigils[3] == 4)
        {
            potion = "grow";
        }
        else if (inputtedSigils[0] == 4 &&
            inputtedSigils[1] == 1 &&
            inputtedSigils[2] == 2 &&
            inputtedSigils[3] == 3)
        {
            potion = "shrink";
        }
        else if (inputtedSigils[0] == 2 &&
            inputtedSigils[1] == 4 &&
            inputtedSigils[2] == 3 &&
            inputtedSigils[3] == 1)
        {
            potion = "vodka";
        }
        else return;

        puzzleOpen.ActivatePuzzle();
    }

    public void ResetSigils()
    {
        Array.Clear(inputtedSigils, 0, inputtedSigils.Length);
        inputtedSigilCount = 0;
    }
}
