using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public bool circlePieceObtained = false;
    public GameObject circlePiece;
    public GameObject circlePieceIcon;

    public void ObtainCirclePiece()
    {
        circlePieceObtained = true;
        circlePiece.SetActive(false);
        circlePieceIcon.SetActive(true);
    }

    public bool trianglePieceObtained = false;
    public GameObject trianglePiece;
    public GameObject trianglePieceIcon;

    public void ObtainTrianglePiece()
    {
        trianglePieceObtained = true;
        trianglePiece.SetActive(false);
        trianglePieceIcon.SetActive(true);
    }
}
