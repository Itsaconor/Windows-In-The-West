using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeely_On_Mouse_Down : MonoBehaviour
{
    
    public AudioSource jeelyNoise;
    // Start is called before the first frame update
   void Start ()
   {
     jeelyNoise = GetComponent<AudioSource>();
   
   }
   
    void OnMouseDown ()
    {
  
    if (!jeelyNoise.isPlaying)
            jeelyNoise.Play();
            Debug.Log("jammin");
    }
    
}