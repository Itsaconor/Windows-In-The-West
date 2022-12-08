using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumAudio : MonoBehaviour
{
    //Fetch Audio Source
    private AudioSource audioSource;
    //Fetch audio Clips
    public AudioClip clipOne;
    public AudioClip clipTwo;
    public AudioClip clipThree;

   
    //Declares 3 Floats to allow the audio to play and stop
    private float myFloat1;
    
    private float myFloat2;
    
    private float myFloat3;

    // Start is called before the first frame update
    void Start()
    {
        //Fetching audio source from game object
        audioSource = GetComponent<AudioSource>();
        //sets 3 floats to 0 at start which means the audio will not play on start
        myFloat1 = 0;
        myFloat2 = 0;
        myFloat3 = 0;
    }

    public void PlayClipOne()
    {
        // If the audio is not playing then the audio source will play when the button is clicked
        if (myFloat1 == 0)
        {
            //sets the audio source clip as clip one which is a public variable
            audioSource.clip = clipOne;
            audioSource.Play();
            //This sets the first float to 1 meaning the audio is playing
            myFloat1 = 1;
        }
            //this else if statement means that the audio will stop if the button is clicked again and sets the float back to 0
        else if (myFloat1 == 1)
        {
            audioSource.Stop();
            myFloat1 = 0;
        }       

    }
    //The lines of code above are repeated for the 3 audio clips and 3 floats which are set at the top of the script
    
    public void PlayClipTwo()
   
    {
        if (myFloat2 == 0)
        {
            audioSource.clip = clipTwo;
            audioSource.Play();
            myFloat2 = 1;
        }       
    

        else if (myFloat2 == 1)
        {
            audioSource.Stop();
            myFloat2 = 0;
        }       
    }

    
    public void PlayClipThree()
   
    {
        if (myFloat3 == 0)
        {
            audioSource.clip = clipThree;
            audioSource.Play();
            myFloat3 = 1;
        }

        else if (myFloat3 == 1)
        {
            audioSource.Stop();
            myFloat3 = 0;
        }        
    }             
}
