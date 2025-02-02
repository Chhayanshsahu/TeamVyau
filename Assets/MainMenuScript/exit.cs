using UnityEngine;
using UnityEngine.UI; // Needed for UI components like Button

public class Exit : MonoBehaviour
{
    // Reference to the exit button
    public Button thatsit;

    // Reference to the GameObject you want to enable/disable
    public GameObject ExitGGG;  // This is now a GameObject, not a Button
    public GameObject Playc;
    void Start()
    {
        // Add a listener to the exit button to call the ToggleGameObject method when clicked
        if (thatsit != null)
        {
            thatsit.onClick.AddListener(ToggleGameObject);
        }

        // Optionally, you can set the ExitGGG GameObject to be disabled at the start
        if (ExitGGG != null)
        {
            ExitGGG.SetActive(false);  // Disable the GameObject initially
        }
    }

    // Method to toggle the ExitGGG GameObject's visibility
    void ToggleGameObject()
    {
         if (Playc != null)
        {
            Playc.SetActive(false);        // Set the opposite state
            Debug.Log("ExitGGG GameObject toggled!");
        }

        if (ExitGGG != null)
        {
            // Toggle the active state (on/off)
            bool isActive = ExitGGG.activeSelf;  // Check the current active state
            ExitGGG.SetActive(!isActive);        // Set the opposite state
            Debug.Log("ExitGGG GameObject toggled!");
        }
    }
}
