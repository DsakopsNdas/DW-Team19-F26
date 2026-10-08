using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    public GameObject northRoom;

    public GameObject eventSystem;
    public RoomChanger roomChanger;

    public GameObject submitButton;
    public DresserPuzzleManager dresserPuzzleManager;

    private void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();
        submitButton = roomChanger.submitButton;
        dresserPuzzleManager = submitButton.GetComponent<DresserPuzzleManager>();
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
            if (puzzle == northRoom)
            {
                if (Type == ItemType.CompleteFirePage)
                {
                    roomChanger.cauldronLit = true;
                }

                if (roomChanger.cauldronLit)
                {
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
            }

            if (puzzle == dresser)
            {
                if (Type == ItemType.Sigil1)
                {
                    dresserPuzzleManager.inputtedSigils[dresserPuzzleManager.inputtedSigilCount] = 1;
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil2)
                {
                    dresserPuzzleManager.inputtedSigils[dresserPuzzleManager.inputtedSigilCount] = 2;
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil3)
                {
                    dresserPuzzleManager.inputtedSigils[dresserPuzzleManager.inputtedSigilCount] = 3;
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil4)
                {
                    dresserPuzzleManager.inputtedSigils[dresserPuzzleManager.inputtedSigilCount] = 4;
                    dresserPuzzleManager.inputtedSigilCount++;
                }
            }
        }
    }
}
