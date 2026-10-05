using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    GameObject movingObject = null;

    public void Click(GameObject clickedObject)
    {
        movingObject = clickedObject;
    }

    private void FixedUpdate()
    {
        if (movingObject != null)
        {
            movingObject.transform.localPosition = Vector3.zero;
        }
    }
}
