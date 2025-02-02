using UnityEngine;
using UnityEngine.UI; // Needed for UI components like Button

public class PlayCompaignController : MonoBehaviour
{
    // Reference to the exit button
    public Button Play;

    // Reference to the GameObject you want to enable/disable
    public GameObject PlayComp;  // This is now a GameObject, not a Button
    public GameObject Exitc;  // This is now a GameObject, not a Button

    void Start()
    {
        // Add a listener to the exit button to call the ToggleGameObject method when clicked
        if (Play != null)
        {
            Play.onClick.AddListener(ToggleGameObject);
        }

        // Optionally, you can set the PlayComp GameObject to be disabled at the start
        if (PlayComp != null)
        {
            PlayComp.SetActive(false);  // Disable the GameObject initially
        }
    }

    // Method to toggle the PlayComp GameObject's visibility
    void ToggleGameObject()
    {
       if (Exitc != null)
        {
            Exitc.SetActive(false);        // Set the opposite state
            Debug.Log("ExitGGG GameObject toggled!");
        }

        if (PlayComp != null)
        {
            // Toggle the active state (on/off)
            bool isActive = PlayComp.activeSelf;  // Check the current active state
            PlayComp.SetActive(!isActive);        // Set the opposite state
            Debug.Log("PlayComp GameObject toggled!");
        }
    }
}
