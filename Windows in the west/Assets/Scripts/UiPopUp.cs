using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPopUp : MonoBehaviour
{
    //this references the ui which can be assigned into the inspector
    public GameObject uiBox;
    
    public void OnMouseDown()
    {
        //this turns on the ai so you can view them 
        uiBox.SetActive(true);
    }
}
