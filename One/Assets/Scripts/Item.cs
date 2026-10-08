using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    None,
    Fire_Paper1,
    Fire_Paper2,
    Fire_Paper3,
    TrianglePiece,
    CirclePiece,
    RotatingPuzzlePiece,
    Leaf,
    Sigil3,
    SlidingTile,
    CompleteFirePage,
    SigilOnTable
}

public class Item : MonoBehaviour
{
    public ItemType Type;
    public Sprite icon;

    private void OnEnable()
    {
        if (icon == null)
        {
            if (gameObject.GetComponent<Image>())
            {
                icon = gameObject.GetComponent<Image>().sprite;
            }
        }

        if (gameObject.GetComponent<Button>())
        {
            gameObject.GetComponent<Button>().onClick.AddListener(() => Items.itemsInstance.ObtainItem(this, gameObject));
        }
    }
}
