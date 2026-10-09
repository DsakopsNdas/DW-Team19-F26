using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScreenSwapper : MonoBehaviour
{
    public GameObject endingManagerObject;
    public EndingManager endingManager;

    public GameObject[] endingLayers = new GameObject[4];

    void Start()
    {
        endingManagerObject = GameObject.FindWithTag("Ending Manager");
        endingManager = endingManagerObject.GetComponent<EndingManager>();

        if (endingManager.potion[0])
        {
            endingLayers[0].SetActive(true);
        }
        else if (endingManager.potion[1])
        {
            endingLayers[1].SetActive(true);
        }
        else if (endingManager.potion[2])
        {
            endingLayers[2].SetActive(true);
        }
        else if (endingManager.potion[3])
        {
            endingLayers[2].SetActive(true);
            endingLayers[3].SetActive(true);
        }
    }
}
