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
    Sigil4,
    Sigil3,
    RotatingPuzzlePiece,
    Leaf,
    Sigil1,
    SlidingTile,
    CompleteFirePage,
    Sigil2,
    Water,
    Crystal
}

public class Item : MonoBehaviour
{
    public ItemType Type;
    public Sprite icon;

    public GameObject puzzle;
    public GameObject dresser;

    public GameObject eventSystem;
    public RoomChanger roomChanger;

    private void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();

    }

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

    public void ItemClick()
    {
        if (puzzle != null)
        {
            if (roomChanger.direction == "north")
            {
                if (Type == ItemType.CompleteFirePage)
                {

                }

                if (Type == ItemType.Water)
                {

                }

                if (Type == ItemType.Leaf)
                {

                }

                if (Type == ItemType.Crystal)
                {

                }
            }

            if (puzzle == dresser)
            {
                if (Type == ItemType.Sigil1)
                {

                }

                if (Type == ItemType.Sigil2)
                {

                }

                if (Type == ItemType.Sigil3)
                {

                }

                if (Type == ItemType.Sigil4)
                {

                }
            }
        }
    }
}
