using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGame : MonoBehaviour
{
    public GameObject[] activeObjects;
    public GameObject[] inactiveObjects;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = activeObjects.Length - 1; i >= 0; i--)
        {
            activeObjects[i].SetActive(true);
        }
        for (int i = inactiveObjects.Length - 1; i >= 0; i--)
        {
            inactiveObjects[i].SetActive(false);
        }
    }
}
