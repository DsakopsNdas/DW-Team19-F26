using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Fire_Paper1,
    Fire_Paper2,
    Fire_Paper3,
    TrianglePiece,
    CirclePiece,
    RotatingPuzzlePiece,
    Leaf,
    Sigil3
}

public class Item : MonoBehaviour
{
    public ItemType Type;
    public Sprite icon;

    private void OnEnable()
    {
        icon = gameObject.GetComponent<Image>().sprite;
        gameObject.GetComponent<Button>().onClick.AddListener(() => Items.itemsInstance.ObtainItem(this, gameObject));
    }
}
