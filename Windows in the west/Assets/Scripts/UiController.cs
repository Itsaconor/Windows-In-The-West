using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
 public void QuitApplication() {
    Debug.LogWarning ("I quit");
    Application.Quit();
 }
 public void LoadScene (string name) {
SceneManager.LoadScene(name, LoadSceneMode.Single);

 }
}
