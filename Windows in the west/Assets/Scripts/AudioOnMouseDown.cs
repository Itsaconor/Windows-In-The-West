using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnMouseDown : MonoBehaviour
{
    public AudioClip myClip;
    AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
        mySource.clip = myClip;
    }

    void OnMouseDown() {
        if (!mySource.isPlaying)
            mySource.Play();
    }
}
