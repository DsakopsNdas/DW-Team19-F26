using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxClose : MonoBehaviour
{
    public GameObject textBox;

    public void CloseTextBox()
    {
        textBox.SetActive(false);
    }
}
