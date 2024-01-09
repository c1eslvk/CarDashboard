using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsScript : MonoBehaviour
{
    public Image imageObject; // Reference to the Image UI component
    public Sprite baseSprite; // The first/default sprite
    public Sprite alternateSprite; // The second sprite

    private bool isBaseSprite = true; // Flag to track the current state

    // Function to switch between sprites on button click
    public void SwitchImage()
    {
        if (imageObject != null)
        {
            // Toggle between sprites
            if (isBaseSprite)
            {
                imageObject.sprite = alternateSprite;
            }
            else
            {
                imageObject.sprite = baseSprite;
            }

            isBaseSprite = !isBaseSprite; // Invert the state flag
        }
    }
}
