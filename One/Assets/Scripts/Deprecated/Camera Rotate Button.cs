using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraRotateButton : MonoBehaviour
{
    //Containers for left and right buttons and camera
    public Button leftButton;
    public Button rightButton;
    public GameObject mainCamera;

    //Camera turn speed modifier
    public float cameraDampening = 5f;

    public Vector3 leftRotate = new Vector3(0, -90, 0);
    public Vector3 rightRotate = new Vector3(0, 90, 0);
    public Quaternion leftTurn;
    public Quaternion rightTurn;

    private void Start()
    {
        //Automatically grabs Camera, less manual work
        mainCamera = GameObject.FindWithTag("MainCamera");
        
        leftTurn = Quaternion.Euler(leftRotate);
        rightTurn = Quaternion.Euler(rightRotate);
    }

    private void Update()
    {
        
    }
}
