using UnityEngine;
using UnityEngine.UI; // Needed for UI components like Button

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ExitController : MonoBehaviour
{
    // Reference to the exit button
    public Button exitButton;

    void Start()
    {
        // Add a listener to the exit button to call the ExitGame method when clicked
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGameApplication);
        }
    }

    // Method to exit the game
    void ExitGameApplication()
    {
        Debug.Log("Exiting the game!");

        // For Unity builds:
        Application.Quit();

        // For testing in the Unity Editor:
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }
}