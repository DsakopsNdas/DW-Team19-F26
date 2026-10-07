using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public List<Item> items = null;
    public List<ItemType> itemTypeList;

    public static Items itemsInstance;

    [SerializeField] GameObject inventoryIcon;
    [SerializeField] Transform inventoryPanel;

    private void Start()
    {
        itemsInstance = GetComponent<Items>();
    }

    public void ObtainItem(Item item, GameObject itemObject)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
        }

        foreach (Item items in items)
        {
            itemTypeList.Add(item.Type);
        }

        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }
        for (int i = 0; i < items.Count; i++)
        {
            GameObject[] iconObject = new GameObject[i + 1];
            iconObject[i] = Instantiate(inventoryIcon, inventoryPanel);
            iconObject[i].GetComponent<Image>().sprite = items[i].icon;
        }

        itemObject.SetActive(false);
    }
}
