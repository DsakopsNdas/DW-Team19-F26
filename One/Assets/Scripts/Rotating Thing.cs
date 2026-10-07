using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotatingThing : MonoBehaviour
{
    private Vector3 rotateLeft = new Vector3(0, 0, 45);
    private Vector3 rotateRight = new Vector3(0, 0, -45);

    [SerializeField] int randomRot;
    [SerializeField] Vector3 startingRot = Vector3.zero;

    [SerializeField] Vector3 mousePos;

    private void Start()
    {
        randomRot = Random.Range(1, 7);
        startingRot.z = randomRot * 45;
        gameObject.transform.Rotate(startingRot, Space.World);
    }

    private void Update()
    {
        mousePos = Input.mousePosition;
    }

    public void Rotate()
    {
        if (mousePos.x <= 1280 / 2)
        {
            gameObject.transform.Rotate(rotateLeft, Space.Self);
            GetComponentInParent<RotatingPuzzleManager>().CheckWin();
        }
        else if (mousePos.x >= 1280 / 2)
        {
            gameObject.transform.Rotate(rotateRight, Space.Self);
            GetComponentInParent<RotatingPuzzleManager>().CheckWin();
        }
    }
}
