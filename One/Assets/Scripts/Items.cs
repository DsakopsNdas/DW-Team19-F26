using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public List<Item> itemsList = null;
    public List<ItemType> itemTypeList;

    public static Items itemsInstance;

    [SerializeField] GameObject inventoryIcon;
    [SerializeField] Transform inventoryPanel;

    public bool firePaper1Collected = false;
    public bool firePaper2Collected = false;
    public bool firePaper3Collected = false;

    public Item completeFirePaper;
    public GameObject sigilOnTable;

    private void Start()
    {
        itemsInstance = GetComponent<Items>();
    }

    public void ObtainItem(Item itemObtained, GameObject itemObject)
    {
        if (!itemsList.Contains(itemObtained))
        {
            itemsList.Add(itemObtained);
        }

        foreach (Item items in itemsList)
        {
            if (!itemTypeList.Contains(itemObtained.Type))
            {
                itemTypeList.Add(itemObtained.Type);
            }
        }

        RenderInventory();

        itemObject.SetActive(false);

        CheckForFirePages(itemObtained);
    }

    public void CheckForFirePages(Item itemObtained)
    {
        foreach (Item items in itemsList)
        {
            if (itemObtained.Type == ItemType.Fire_Paper1)
            {
                firePaper1Collected = true;
            }
            if (itemObtained.Type == ItemType.Fire_Paper2)
            {
                firePaper2Collected = true;
            }
            if (itemObtained.Type == ItemType.Fire_Paper3)
            {
                firePaper3Collected = true;
            }
        }
    }

    private void Update()
    {
        CombinePages();
    }

    public void CombinePages()
    {
        if (firePaper1Collected &&
            firePaper2Collected &&
            firePaper3Collected)
        {
            foreach (Item items in itemsList)
            {
                if (items.Type == ItemType.Fire_Paper1)
                {
                    itemsList.Remove(items);
                    return;
                }
                if (items.Type == ItemType.Fire_Paper2)
                {
                    itemsList.Remove(items);
                    return;
                }
                if (items.Type == ItemType.Fire_Paper3)
                {
                    itemsList.Remove(items);
                    return;
                }
            }

            itemTypeList.Remove(ItemType.Fire_Paper1);
            itemTypeList.Remove(ItemType.Fire_Paper2);
            itemTypeList.Remove(ItemType.Fire_Paper3);

            itemsList.Add(completeFirePaper);
            itemTypeList.Add(completeFirePaper.Type);

            firePaper1Collected = false;
            firePaper2Collected = false;
            firePaper3Collected = false;

            RenderInventory();

            sigilOnTable.SetActive(true);
        }
    }

    public void RenderInventory()
    {
        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }
        for (int i = 0; i < itemsList.Count; i++)
        {
            GameObject[] iconObject = new GameObject[i + 1];
            iconObject[i] = Instantiate(inventoryIcon, inventoryPanel);

            if (itemsList[i].icon != null)
            {
                iconObject[i].GetComponent<Image>().sprite = itemsList[i].icon;
            }
        }
    }
}