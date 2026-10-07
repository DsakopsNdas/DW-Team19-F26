using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleOpen : MonoBehaviour
{
    public GameObject parentRoom;
    public GameObject targetPuzzle;

    public bool navButtonsOnAtTargetScene;
    public bool inventoryOnAtTargetScene;

    public GameObject eventSystem;
    public RoomChanger roomChanger;

    public ItemType requiredItem;
    public Items itemsManager;

    public void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();
        itemsManager = eventSystem.GetComponent<Items>();
    }

    public void ActivatePuzzle()
    {
        if (requiredItem != ItemType.None)
        {
            if (itemsManager.itemTypeList.Contains(requiredItem))
            {
                ChangeRoom();
            }
        } 
        else if (requiredItem == ItemType.None)
        {
            ChangeRoom();
        }
    }

    public void ChangeRoom()
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

        if (inventoryOnAtTargetScene)
        {
            roomChanger.inventory.SetActive(true);
        }
        else if (!inventoryOnAtTargetScene)
        {
            roomChanger.inventory.SetActive(false);
        }
    }
}
