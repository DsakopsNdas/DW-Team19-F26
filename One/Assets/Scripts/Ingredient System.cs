using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSystem : MonoBehaviour
{
    public GameObject leaf;
    public GameObject leafIcon;

    public void ObtainLeaf()
    {
        leaf.SetActive(false);
        leafIcon.SetActive(true);
    }
}
