using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    public GameObject northRoom;
    public GameObject eastRoom;
    public GameObject southRoom;
    public GameObject westRoom;

    public void activateNorth()
    {
        northRoom.SetActive(true);
        eastRoom.SetActive(false);
        southRoom.SetActive(false);
        westRoom.SetActive(false);
    }
    public void activateEast()
    {
        northRoom.SetActive(false);
        eastRoom.SetActive(true);
        southRoom.SetActive(false);
        westRoom.SetActive(false);
    }
    public void activateSouth()
    {
        northRoom.SetActive(false);
        eastRoom.SetActive(false);
        southRoom.SetActive(true);
        westRoom.SetActive(false);
    }
    public void activateWest()
    {
        northRoom.SetActive(false);
        eastRoom.SetActive(false);
        southRoom.SetActive(false);
        westRoom.SetActive(true);
    }
}
