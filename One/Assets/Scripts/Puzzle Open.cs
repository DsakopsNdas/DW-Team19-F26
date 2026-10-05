using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleOpen : MonoBehaviour
{
    public GameObject parentRoom;
    public GameObject targetPuzzle;
    public bool navButtonsOnAtTargetScene;

    public GameObject eventSystem;
    public RoomChanger roomChanger;

    public void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();
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
