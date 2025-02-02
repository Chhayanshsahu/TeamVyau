using UnityEngine;

public class SimpleDoor : MonoBehaviour
{
    public Transform door; // Reference to the door's Transform
    public float openAngle = 90f; // Angle to rotate the door when opening
    public float rotationSpeed = 2f; // Speed of door rotation

    private bool isOpen = false; // Track if the door is open
    private bool nearDoor = false; // Track if the player is near the door
    private Quaternion initialRotation; // Store the door's initial rotation
    private Quaternion targetRotation; // Target rotation for the door

    void Start()
    {
        // Store the door's initial rotation
        initialRotation = door.rotation;
        // Calculate the target rotation when the door is open
        targetRotation = initialRotation * Quaternion.Euler(0, openAngle, 0);
    }

    void Update()
    {
        // Check if the player is near the door and presses 'E'
        if (nearDoor && Input.GetKeyDown(KeyCode.E))
        {
            // Toggle the door state (open/close)
            isOpen = !isOpen;
        }

        // Smoothly rotate the door to its target rotation
        if (isOpen)
        {
            door.rotation = Quaternion.Lerp(door.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }
        else
        {
            door.rotation = Quaternion.Lerp(door.rotation, initialRotation, Time.deltaTime * rotationSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player is near the door
        if (other.CompareTag("Player"))
        {
            nearDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player has left the door area
        if (other.CompareTag("Player"))
        {
            nearDoor = false;
        }
    }
}