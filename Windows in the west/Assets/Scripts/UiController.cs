using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
   //this creates a function to close the application after clicking a button
 public void QuitApplication() {
    Debug.LogWarning ("I quit");

   //this makes the application quit
    Application.Quit();
 }
 //this allows for a button click to change scenes within unity
 public void LoadScene (string name) {

//scene manager loads the next scene 
SceneManager.LoadScene(name, LoadSceneMode.Single);

 }
}
