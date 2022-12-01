//This script will allow me to have the emission value turned on for the mouse hovering over the fog horn and plays a foghorn noise when clicked.

using UnityEngine;

public class OnMouseOverColor : MonoBehaviour
{
    //These are the sources I will call in
    MeshRenderer m_Renderer;
    //Two set materials for the hover mouse
    public Material standardMat;
    public Material emissionMat;


    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        // sets the m render mat to standard material
       m_Renderer.material = standardMat; 
    
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
    public void OnMouseDown()
    {

    }
     
}
