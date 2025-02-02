using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class ContinueController : MonoBehaviour
{
    // Name of the scene to load when "Continue" is clicked
    public string sceneToLoad = "Envir";

    // This method is called when the "Continue" button is clicked
    public void OnContinueButtonClicked()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}