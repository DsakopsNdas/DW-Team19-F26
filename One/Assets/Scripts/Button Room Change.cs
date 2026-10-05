using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRoomChange : MonoBehaviour
{
    public RoomChanger roomChanger;

    public void Start()
    {
        roomChanger = GetComponentInParent<RoomChanger>();
    }

    public void leftRoomChange()
    {
        if (roomChanger.direction == "north")
        {
            roomChanger.ActivateWest();
        }
        else if (roomChanger.direction == "east")
        {
            roomChanger.ActivateNorth();
        }
        else if (roomChanger.direction == "south")
        {
            roomChanger.ActivateEast();
        }
        else if (roomChanger.direction == "west")
        {
            roomChanger.ActivateSouth();
        }
    }
    // gahhhhh
    public void rightRoomChange()
    {
        if (roomChanger.direction == "north")
        {
            roomChanger.ActivateEast();
        }
        else if (roomChanger.direction == "east")
        {
            roomChanger.ActivateSouth();
        }
        else if (roomChanger.direction == "south")
        {
            roomChanger.ActivateWest();
        }
        else if (roomChanger.direction == "west")
        {
            roomChanger.ActivateNorth();
        }
    }
}
