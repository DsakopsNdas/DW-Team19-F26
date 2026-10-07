using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPuzzleManager : MonoBehaviour
{
    [SerializeField] GameObject outerRing;
    [SerializeField] GameObject middleRing;
    [SerializeField] GameObject centralRing;

    [SerializeField] GameObject rotatingPuzzle;
    [SerializeField] GameObject rotatingPuzzleComplete;

    [SerializeField] GameObject rotatingPuzzleButton;

    public void CheckWin()
    {
        if (isZero(outerRing.transform.rotation.eulerAngles.z)
            && isZero(middleRing.transform.rotation.eulerAngles.z) 
            && isZero(centralRing.transform.rotation.eulerAngles.z))
        {
            rotatingPuzzleButton.GetComponent<PuzzleOpen>().targetPuzzle = rotatingPuzzleComplete;

            rotatingPuzzleComplete.SetActive(true);
            rotatingPuzzle.SetActive(false);
        }
    }

    public bool isZero(float rotation)
    {
        return rotation < 1 && rotation > -1;
    }
}
