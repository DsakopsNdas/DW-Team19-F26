using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotionMaker : MonoBehaviour
{
    public bool waterIn = false;
    public bool leafIn = false;
    public bool crystalBurn = false;
    public bool crystalGrow = false;
    public bool crystalShrink = false;
    public bool crystalVodka = false;

    public GameObject cauldronFire;
    public GameObject cauldronOnFire;
    public GameObject cauldronNoFire;

    public GameObject eventSystem;
    public Items itemsManager;

    public void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        itemsManager = eventSystem.GetComponent<Items>();
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
                crystalBurn = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal2)
            {
                crystalGrow = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal3)
            {
                crystalShrink = true;
                UseItem(Type);
            }

            if (Type == ItemType.Crystal4)
            {
                crystalVodka = true;
                UseItem(Type);
            }
        }
    }

    public void CheckPotion()
    {
        if (waterIn &&
            leafIn &&
            crystalBurn)
        {
            SceneManager.LoadScene(2);
        }
        else if (waterIn &&
            leafIn &&
            crystalGrow)
        {
            SceneManager.LoadScene(2);
        }
        else if (waterIn &&
            leafIn &&
            crystalShrink)
        {
            SceneManager.LoadScene(2);
        }
        else if (waterIn &&
            leafIn &&
            crystalVodka)
        {
            SceneManager.LoadScene(2);
        }
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

