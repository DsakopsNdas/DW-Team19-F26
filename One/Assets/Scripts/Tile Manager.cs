using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    private int rows = 3;
    private int cols = 3;
    public GameObject tilePrefab;
    public RectTransform board;

    [SerializeField] List<GameObject> tiles = new List<GameObject>();
    private Vector2 emptySpace;

    float size = 150f; // tile size

    public Sprite[] tileSprites = new Sprite[8];

    public GameObject cabinet;
    public GameObject cabinetComplete;
    public GameObject cabinetButton;
    private PuzzleOpen cabinetButtonScript;

    void Start()
    {
        CreateBoard();
        Shuffle();
        
        cabinetButtonScript = cabinetButton.GetComponent<PuzzleOpen>();
    }

    public void CreateBoard()
    {
        
        emptySpace = new Vector2(cols - 1, rows - 1);

        int number = 1;
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                if (x == cols - 1 && y == rows - 1) continue; // leave empty

                GameObject tile = Instantiate(tilePrefab, board);
                tile.GetComponentInChildren<Image>().sprite = tileSprites[number - 1];

                RectTransform rt = tile.GetComponent<RectTransform>();
                rt.transform.position = new Vector2(x * size, -y * size);
                rt.anchoredPosition = new Vector2(x * size, -y * size);

                tile.GetComponent<Tile>().Init(new Vector2(x, y), this);

                tiles.Add(tile);
                number++;
            }
        }
    }

    public void ClearBoard()
    {
        for (int i = tiles.Count - 1; i > -1; i--)
        {
            Debug.Log(tiles.Count);
            Destroy(tiles[i].gameObject);
        }
        tiles.Clear();
    }


    public bool IsNextToEmpty(Vector2 pos)
    {
        return (Mathf.Abs(pos.x - emptySpace.x) == 1 && pos.y == emptySpace.y) ||
               (Mathf.Abs(pos.y - emptySpace.y) == 1 && pos.x == emptySpace.x);
    }

    public void MoveTile(Tile tile)
    {
        if (IsNextToEmpty(tile.pos))
        {
            Vector2 oldPos = tile.pos;
            tile.Move(emptySpace);
            emptySpace = oldPos;
            CheckWin();
        }
        
    }

    public void Shuffle()
    {
        // Simple shuffle: randomize tile moves
        for (int i = 0; i < 150; i++)
        {
            foreach (var tile in tiles)
            {
                if (IsNextToEmpty(tile.GetComponent<Tile>().pos))
                    MoveTile(tile.GetComponent<Tile>());
            }
        }
    }

    public void CheckWin()
    {
        int number = 1;
        foreach (var tile in tiles)
        {
            int expectedX = (number - 1) % cols;
            int expectedY = (number - 1) / cols;
            if (tile.GetComponent<Tile>().pos != new Vector2(expectedX, expectedY))
                return;
            number++;
        }
        cabinetButtonScript.targetPuzzle = cabinetComplete;
        
        StartCoroutine(openCabinet());
    }

    IEnumerator openCabinet()
    {
        yield return new WaitForSeconds(1.5f);

        cabinetComplete.SetActive(true);
        cabinet.SetActive(false);
    }

}

