using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RpmScript : MonoBehaviour
{
    [SerializeField] private Image rpmImage;
    [SerializeField] private Slider speedSlider;

    private float maxSpeed = 160f; // Maximum speed of the car in km/h
    private float maxRPM = 0.4375f; // Maximum RPM of the engine (43.75% of the circle)
    private float currentRPM = 0.1f; // Current RPM value (initial RPM, corresponds to gear 1)
    private int currentGear = 1; // Current gear of the car

    private float[] gearChangeRPMs = { 0.3125f, 0.2625f, 0.2125f, 0.1625f, 0.1125f, 0.0625f }; // RPMs to change gears

    void Start()
    {
        rpmImage.fillAmount = currentRPM;
    }

    void Update()
    {
        float currentSpeed = speedSlider.value; // Get current speed from the slider

        // Calculate RPM based on speed and current gear
        float targetRPM = Mathf.Lerp(0.1f, maxRPM, currentSpeed / maxSpeed);

        // If RPM exceeds the gear change RPM, change gear and adjust RPM
        if (currentRPM >= gearChangeRPMs[currentGear - 1] && currentGear < gearChangeRPMs.Length)
        {
            currentGear++;
            targetRPM -= 0.1f; // Decrease RPM after changing gear
        }

        // Smoothly transition the RPM towards the target RPM
        currentRPM = Mathf.Lerp(currentRPM, targetRPM, Time.deltaTime);

        // Update the UI with the current RPM
        rpmImage.fillAmount = currentRPM;
    }
}
