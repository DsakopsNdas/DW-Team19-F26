using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    public GameObject northRoom;
    public GameObject eastRoom;
    public GameObject southRoom;
    public GameObject westRoom;

    public string direction = "north";

    public GameObject navButtons;
    public GameObject inventory;

    public void ActivateNorth()
    {
        direction = "north";
        northRoom.SetActive(true);
        eastRoom.SetActive(false);
        southRoom.SetActive(false);
        westRoom.SetActive(false);
    }
    public void ActivateEast()
    {
        direction = "east";
        northRoom.SetActive(false);
        eastRoom.SetActive(true);
        southRoom.SetActive(false);
        westRoom.SetActive(false);
    }
    public void ActivateSouth()
    {
        direction = "south";
        northRoom.SetActive(false);
        eastRoom.SetActive(false);
        southRoom.SetActive(true);
        westRoom.SetActive(false);
    }
    public void ActivateWest()
    {
        direction = "west";
        northRoom.SetActive(false);
        eastRoom.SetActive(false);
        southRoom.SetActive(false);
        westRoom.SetActive(true);
    }
}
