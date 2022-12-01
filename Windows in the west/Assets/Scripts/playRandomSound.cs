using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// currently this script will play on Awake. Need to change it to play OnClick. 22/11/22

public class playRandomSound : MonoBehaviour
{
    public AudioSource myClip;
    public AudioClip[] audioClipArray;

    // Start is called before the first frame update
    void Start() {
        myClip = GetComponent<AudioSource> ();

       
    }
    
    void OnMouseDown() {

        myClip.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        myClip.Play();

    }
}