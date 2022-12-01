using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Change_Camera_OnMouseDown : MonoBehaviour
{

    public GameObject Roomcamera;
    public GameObject Maincamera;
    // Start is called before the first frame update


    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
         Roomcamera.SetActive(true);
         Maincamera.SetActive(false);
    }

}
