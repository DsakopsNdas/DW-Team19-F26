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

    public List<ItemType> requiredItems;
    public Items itemsManager;
    public bool itemUsed = false;

    public void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();
        itemsManager = eventSystem.GetComponent<Items>();
    }

    public void ActivatePuzzle()
    {
        if (requiredItems.Count != 0 && itemUsed == false)
        {
            foreach (var item in requiredItems)
            {
                if (itemsManager.itemTypeList.Contains(item))
                {
                    ChangeRoom();
                    itemUsed = true;
                    foreach (Item items in itemsManager.itemsList)
                    {
                        if (items.Type == item)
                        {
                            itemsManager.itemsList.Remove(items);
                            itemsManager.RenderInventory();
                            break;
                        }
                    }

                    itemsManager.itemTypeList.Remove(item);
                    itemsManager.RenderInventory();
                }
            }
        } 
        else
        {
            ChangeRoom();
            itemsManager.RenderInventory();
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
