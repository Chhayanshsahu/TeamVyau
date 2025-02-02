using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController3 : MonoBehaviour
{
    [SerializeField]
    private GameObject _object;
    [SerializeField]
    private Transform[] Images;
    [SerializeField]
    private GameObject winText;
    public static bool youWin;

    private const float RotationThreshold = 0.01f; // Threshold for rotation comparison

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        // Check if all Images' rotations are approximately 0 on the Z-axis
        bool allRotationsZero = true;
        foreach (var image in Images)
        {
            if (Mathf.Abs(image.rotation.z) > RotationThreshold)
            {
                allRotationsZero = false;
                break;
            }
        }

        if (allRotationsZero && !youWin)
        {
            youWin = true;
            Cursor.lockState = CursorLockMode.Locked;
            StartCoroutine(WinSequence());
        }
    }

    private IEnumerator WinSequence()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        winText.SetActive(true); // Activate win text
        Destroy(_object); // Destroy the _object after delay

        yield return new WaitForSeconds(4f); // Wait for 4 seconds before changing the scene

        // Load the "Envir1" scene
        SceneManager.LoadScene("Envir1", LoadSceneMode.Single);
    }
}