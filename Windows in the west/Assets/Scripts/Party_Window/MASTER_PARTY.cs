using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MASTER_PARTY : MonoBehaviour



{
     //These lines call in the mesh renderers for both the party window and the clickable window
    MeshRenderer m_Renderer;
    MeshRenderer partyRenderer;
     //These are public variables that are assigned in the inspector. 
     //These are the two materials for the on mouse hover colour change
    public Material standardMat;
    public Material emissionMat;
     // This line calls in the Sound clip for the on mouse down section of the code
    public AudioSource partyNoise;
    //This sets the material for the Party Window
    public Material partyMat;
    //This references in the second window that is not clicked that i call the party window
    public GameObject partyWindow;


    // Start is called before the first frame update
    void Start()
    {
             //Fetch the mesh renderer component from the GameObject
             m_Renderer = GetComponent<MeshRenderer>();
             partyRenderer = partyWindow.GetComponent<MeshRenderer>();
             // sets the m render mat to standard material
             m_Renderer.material = standardMat; 
             partyNoise = GetComponent<AudioSource>();
    }
    
    void OnMouseOver()
    {
        //this sets the render material as the emission mat when the mouse is over.
        m_Renderer.material = emissionMat;
    }

     void OnMouseExit()
     {
       //this resets the material to standard mat when the mouse is no longer over mesh. 
        m_Renderer.material = standardMat;
     }
    
    void OnMouseDown()
    {
          
        
            Debug.Log("mouseclick");
            //This sets the material on the click to party material
            partyRenderer.material = partyMat;
            //This starts a co routine so that the material only changes whilst the audio plays
            StartCoroutine(ChangeColour());
        
        
             //this line plays the audio clip on a mouse click.
             if (!partyNoise.isPlaying);
             {
             partyNoise.Play();
             Debug.Log("baaarp");
             
            }   
    }

           
       
    
  

  IEnumerator ChangeColour()
       {
            Debug.Log("CoroutineStarted");
          //This sets the coroutine to change the material for the party window for 16 seconds
            yield return new WaitForSeconds(16f);
            
            partyRenderer.material = standardMat;

            
       }        
}
