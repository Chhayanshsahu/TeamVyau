using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateImage2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameController.youWin) // Corrected class name to match the previous script
        {
            transform.Rotate(0f, 0f,180f); // Rotates the image by 90 degrees on the Z-axis
        }
    }

}
