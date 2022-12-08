using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Change_Camera_OnMouseDown : MonoBehaviour
{
    //this calls in both cameras in the scene
    public GameObject Roomcamera;
    public GameObject Maincamera;
    // Start is called before the first frame update


    void OnMouseDown()
    {
        //This if statement essentially states that the cameras will switch as only one camera can be active in a scene at any one time.
        if (Input.GetMouseButtonDown(0))
         Roomcamera.SetActive(true);
         Maincamera.SetActive(false);
    }

}
