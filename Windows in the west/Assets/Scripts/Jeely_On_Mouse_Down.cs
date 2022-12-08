using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeely_On_Mouse_Down : MonoBehaviour
{
    //calls in the audio source or audio clip
    public AudioSource jeelyNoise;
    // Start is called before the first frame update
   void Start ()
   {
    //this fetches the audio source from game object component list
     jeelyNoise = GetComponent<AudioSource>();
   
   }
   
    void OnMouseDown ()
    {
      //this stops the audio from playing once it has been clicked
    if (!jeelyNoise.isPlaying)
            //this plays the clip
            jeelyNoise.Play();
            Debug.Log("jammin");
    }
    
    //this public function allows the music to be paused or stopped when a button is clicked and can be referenced onto a ui button
    public void StopMusic()
    {
          //this pauses the audio
      jeelyNoise.Pause();
    }
}