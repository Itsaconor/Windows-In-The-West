using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke_Script : MonoBehaviour
{
    //This public variable calls in the particle system
    public GameObject smokebit;
    //This calls in the audio for the chimney click
    public AudioSource smokeNoise;
    // Start is called before the first frame update
   void Start ()
   {
     smokeNoise = GetComponent<AudioSource>();
   
   }
   
    void OnMouseDown ()
    {
      //this sets the particle system to play
    smokebit.SetActive(true);
    //this stops the audio from repeating when it is already playing
    if (!smokeNoise.isPlaying)
      //this line plays the audio
            smokeNoise.Play();
            Debug.Log("baaarp");
    }
    
}