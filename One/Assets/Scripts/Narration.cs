using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string[] inventory = new string[] {
                                           "You wake up in a strange cabin, alone and unsure of how you got here.",
                                           "An uneasy feeling settles in you as you look around, you must escape;",
                                           "A cauldron is in front of you. Maybe you can use it to escape.",
                                           "There's a hole in the wall but you’re way too big to fit. Maybe you can yourself shrink down.",
                                           "Start by heating up the cauldron. There must be something to start a fire around here somewhere..."
                                          };

        //Console.WriteLine(inventory[0]); <- Call when needed.

    }

}
