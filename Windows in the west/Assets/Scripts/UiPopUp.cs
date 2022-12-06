using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPopUp : MonoBehaviour
{

    public GameObject uiBox;

    public void OnMouseDown()
    {
        uiBox.SetActive(true);
    }
}
