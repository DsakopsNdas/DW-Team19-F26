using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public Vector2 pos;
    private TileManager board;

    public void Init(Vector2 startPos, TileManager manager)
    {
        pos = startPos;
        board = manager;
    }

    public void Move(Vector2 newPos)
    {
        pos = newPos;
        RectTransform rt = GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(newPos.x * 150f, -newPos.y * 150f);
        //rt.transform.position = new Vector2(newPos.x * 150f, -newPos.y * 150f);
    }

    public void OnClick()
    {
        board.MoveTile(this);
    }
}