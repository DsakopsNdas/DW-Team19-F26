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
    Crystal1,
    Crystal2,
    Crystal3,
    Crystal4
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

    public PotionMaker potionMaker;

    private void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        roomChanger = eventSystem.GetComponent<RoomChanger>();
        submitButton = roomChanger.submitButton;
        dresserPuzzleManager = submitButton.GetComponent<DresserPuzzleManager>();
        potionMaker = eventSystem.GetComponent<PotionMaker>();
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
                potionMaker.AddToCauldron(Type, roomChanger);
            }

            if (puzzle == dresser)
            {
                if (Type == ItemType.Sigil1)
                {
                    dresserPuzzleManager.InputSigil(1);
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil2)
                {
                    dresserPuzzleManager.InputSigil(2);
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil3)
                {
                    dresserPuzzleManager.InputSigil(3);
                    dresserPuzzleManager.inputtedSigilCount++;
                }

                if (Type == ItemType.Sigil4)
                {
                    dresserPuzzleManager.InputSigil(4);
                    dresserPuzzleManager.inputtedSigilCount++;
                }
            }
        }
    }
}
