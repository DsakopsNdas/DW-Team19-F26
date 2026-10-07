using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] List<Item> items = null;

    public static Items itemsInstance;

    private void Start()
    {
        itemsInstance = GetComponent<Items>();
    }

    public void ObtainItem(Item item, GameObject itemObject)
    {
        items.Add(item);
        itemObject.SetActive(false);
    }
}
