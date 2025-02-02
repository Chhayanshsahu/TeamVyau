using UnityEngine;
using UnityEngine.UI; // Needed for UI components like Button

public class CloseExit : MonoBehaviour
{
    // Reference to the exit button
    public Button No;

    // Reference to the GameObject you want to disable
    public GameObject Exit;  // This is now a GameObject, not a Button

    void Start()
    {
        // Add a listener to the exit button to call the DisableGameObject method when clicked
        if (No != null)
        {
            No.onClick.AddListener(DisableGameObject);
        }

        // Optionally, you can set the Exit GameObject to be enabled initially
        if (Exit != null)
        {
            Exit.SetActive(false);  // Ensure it's initially enabled
        }
    }

    // Method to disable the Exit GameObject
    void DisableGameObject()
    {
        if (Exit != null)
        {
            Exit.SetActive(false);  // Disable the GameObject
            Debug.Log("Exit GameObject has been disabled!");
        }
    }
}





