using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reshuffle : MonoBehaviour
{
    public GameObject eventSystem;
    public TileManager tileManager;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem = GameObject.FindWithTag("Event System");
        tileManager = eventSystem.GetComponent<TileManager>();
    }

    public void ReshuffleBoard()
    {
        tileManager.Shuffle();
    }
}
