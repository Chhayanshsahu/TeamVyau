using UnityEngine;
using UnityEngine.UI; // Needed for UI components like Button

public class CloseHelp : MonoBehaviour
{
    // Reference to the exit button
    public Button Help;

    // Reference to the GameObject you want to disable
    public GameObject HelpWindow;  // This is Helpw a GameObject, Helpt a Button
public GameObject MainMenu;
    void Start()
    {
        // Add a listener to the exit button to call the DisableGameObject method when clicked
        if (Help != null)
        {
            Help.onClick.AddListener(enableGameObject);
        }

        // Optionally, you can set the MainMenu GameObject to be enabled initially
        if (MainMenu != null)
        {
            MainMenu.SetActive(false);  // Ensure it's initially enabled
        }
        if (HelpWindow != null)
        {
            HelpWindow.SetActive(true);  // Ensure it's initially enabled
        }
    }

    // Method to disable the MainMenu GameObject
    void enableGameObject()
    {
        if (MainMenu != null)
        {
            MainMenu.SetActive(true);  // Disable the GameObject
            Debug.Log("MainMenu GameObject has been disabled!");
        }
        if (HelpWindow != null)
        {
            HelpWindow.SetActive(false);  // Disable the GameObject
            Debug.Log("HelpWindow GameObject has been disabled!");
        }
    }
}





