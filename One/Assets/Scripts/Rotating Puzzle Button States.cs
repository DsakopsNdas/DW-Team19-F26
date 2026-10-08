using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPuzzleButtonStates : MonoBehaviour
{
    public PuzzleOpen rotatingPuzzleButton;
    public GameObject centralRing;
    public GameObject centralRingNoSigil;

    public void SetState()
    {
        if (rotatingPuzzleButton.itemUsed)
        {
            centralRing.SetActive(true);
        }
    }

    public void SigilObtained()
    {
        if (rotatingPuzzleButton.itemUsed)
        {
            centralRing.SetActive(false);
            centralRingNoSigil.SetActive(true);
        }
    }
}
