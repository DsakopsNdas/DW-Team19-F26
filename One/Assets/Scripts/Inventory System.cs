using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public GameObject circlePiece;
    public bool circlePieceObtained = false;
    public GameObject circlePieceIcon;

    public void ObtainCirclePiece()
    {
        circlePieceObtained = true;
        circlePiece.SetActive(false);
        circlePieceIcon.SetActive(true);
    }
}
