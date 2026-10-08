using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public bool[] potion = new bool[4];

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
