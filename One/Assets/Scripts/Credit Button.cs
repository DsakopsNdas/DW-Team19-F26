using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditButton : MonoBehaviour
{
    public GameObject credits;
    public bool creditsActive;

    private void Start()
    {
        credits.SetActive(false);
        creditsActive = false;
    }

    public void Credits()
    {
        if (creditsActive == false)
        {
            credits.SetActive (true);
            creditsActive = true;
        }
        else if (creditsActive == true)
        {
            credits.SetActive(false);
            creditsActive = false;
        }
    }
}
