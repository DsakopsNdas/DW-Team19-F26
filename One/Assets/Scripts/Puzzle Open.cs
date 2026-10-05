using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleOpen : MonoBehaviour
{
    public GameObject parentRoom;
    public GameObject targetPuzzle;
    public bool navButtonsOnAtTargetScene;

    public RoomChanger roomChanger;

    public void Start()
    {
        roomChanger = GetComponentInParent<RoomChanger>();
    }

    public void ActivatePuzzle()
    {
        targetPuzzle.SetActive(true);
        parentRoom.SetActive(false);

        if (navButtonsOnAtTargetScene)
        {
            roomChanger.navButtons.SetActive(true);
        }
        else if (!navButtonsOnAtTargetScene)
        {
            roomChanger.navButtons.SetActive(false);
        }
    }
}
