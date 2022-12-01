using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke_Script : MonoBehaviour
{
    public GameObject smokebit;
    public AudioSource smokeNoise;
    // Start is called before the first frame update
   void Start ()
   {
     smokeNoise = GetComponent<AudioSource>();
   
   }
   
    void OnMouseDown ()
    {
    smokebit.SetActive(true);
    if (!smokeNoise.isPlaying)
            smokeNoise.Play();
            Debug.Log("baaarp");
    }
    
}