using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingThing : MonoBehaviour
{
    private Vector3 rotateLeft = new Vector3(0, 0, 45);
    private Vector3 rotateRight = new Vector3(0, 0, -45);

    [SerializeField] Vector3 mousePos;

    private void Update()
    {
        mousePos = Input.mousePosition;
    }

    public void Rotate()
    {
        if (mousePos.x <= 1280 / 2)
        {
            gameObject.transform.Rotate(rotateLeft, Space.Self);
        }
        else if (mousePos.x >= 1280 / 2)
        {
            gameObject.transform.Rotate(rotateRight, Space.Self);
        }
    }
}
