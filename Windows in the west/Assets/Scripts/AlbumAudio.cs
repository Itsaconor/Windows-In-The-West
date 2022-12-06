using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumAudio : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip clipOne;
    public AudioClip clipTwo;
    public AudioClip clipThree;

   

    private float myFloat1;
    
    private float myFloat2;
    
    private float myFloat3;

    // Start is called before the first frame update
    void Start()
    {
    
        audioSource = GetComponent<AudioSource>();
        myFloat1 = 0;
        myFloat2 = 0;
        myFloat3 = 0;
    }

    public void PlayClipOne()
    {
        if (myFloat1 == 0)
        {
            audioSource.clip = clipOne;
            audioSource.Play();
            myFloat1 = 1;
        }

        else if (myFloat1 == 1)
        {
            audioSource.Stop();
            myFloat1 = 0;
        }       

    }

    
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
