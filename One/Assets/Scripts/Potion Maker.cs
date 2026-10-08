using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PotionMaker : MonoBehaviour
{
    public bool waterIn = false;
    public bool leafIn = false;

    public GameObject cauldronFire;
    public GameObject cauldronOnFire;
    public GameObject cauldronNoFire;

    public GameObject eventSystem;
    public Items itemsManager;

    public EndingManager endingManager;

    public GameObject[] potions = new GameObject[4];

    public void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        itemsManager = eventSystem.GetComponent<Items>();

        for (int i = potions.Length; i > 0; i--)
        {
            potions[i - 1].GetComponent<Button>().onClick.AddListener(DrinkPotion);
        }
    }

    public void AddToCauldron(ItemType Type, RoomChanger roomChanger)
    {
        if (Type == ItemType.CompleteFirePage)
        {
            roomChanger.cauldronLit = true;
            cauldronFire.SetActive(true);
            cauldronOnFire.SetActive(true);
            cauldronNoFire.SetActive(false);
            UseItem(Type);
        }

        if (roomChanger.cauldronLit)
        {
            if (Type == ItemType.Water)
            {
                waterIn = true;
                UseItem(Type);
            }

            if (Type == ItemType.Leaf)
            {
                leafIn = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal1)
            {
                endingManager.potion[0] = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal2)
            {
                endingManager.potion[1] = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal3)
            {
                endingManager.potion[2] = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal4)
            {
                endingManager.potion[3] = true;
                UseItem(Type);
            }
        }
    }

    public void CheckPotion()
    {
        if (waterIn &&
            leafIn &&
            endingManager.potion[0])
        {
            potions[0].SetActive(true);
        }
        else if (waterIn &&
            leafIn &&
            endingManager.potion[1])
        {
            potions[1].SetActive(true);
        }
        else if (waterIn &&
            leafIn &&
            endingManager.potion[2])
        {
            potions[2].SetActive(true);
        }
        else if (waterIn &&
            leafIn &&
            endingManager.potion[3])
        {
            potions[3].SetActive(true);
        }
    }

    public void DrinkPotion()
    {
        SceneManager.LoadScene(2);
    }

    private void UseItem(ItemType usedItem)
    {
        if (itemsManager.itemTypeList.Contains(usedItem))
        {
            foreach (Item items in itemsManager.itemsList)
            {
                if (items.Type == usedItem)
                {
                    itemsManager.itemsList.Remove(items);
                    itemsManager.RenderInventory();
                    break;
                }
            }

            itemsManager.itemTypeList.Remove(usedItem);
            itemsManager.RenderInventory();
        }
        CheckPotion();
    }
}

