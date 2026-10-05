using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRotateButton : MonoBehaviour
{
    public Button button;
    public GameObject mainCamera;
    public bool rotatesLeft;
    public bool rotatesRight;

    private void Start()
    {
        button = GetComponent<Button>();
        mainCamera = GameObject.FindWithTag("MainCamera");
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        if (rotatesLeft)
        {
            mainCamera.transform.Rotate(0, -90, 0, Space.World);
        }

        if (rotatesRight)
        {
            mainCamera.transform.Rotate(0, 90, 0, Space.World);
        }
    }
}
