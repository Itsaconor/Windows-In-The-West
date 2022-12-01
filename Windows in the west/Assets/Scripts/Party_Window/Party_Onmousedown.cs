using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party_Onmousedown : MonoBehaviour

{
    MeshRenderer m_Renderer;
    public AudioSource partyNoise;
    public Material partyMat;
    public Material standardMat;

    // Start is called before the first frame update

    void Start()

    {
        m_Renderer = GetComponent<MeshRenderer>();
        partyNoise = GetComponent<AudioSource>();
        m_Renderer.material = standardMat;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
          if (Input.GetMouseButtonDown(0))
        {
            m_Renderer.material = partyMat;
        }
        {
             //this line plays the audio clip on a mouse click.
             if (!partyNoise.isPlaying);
             {
             partyNoise.Play();
             Debug.Log("baaarp");
             
            }   
             }

           
       
    
  }         
    
}
