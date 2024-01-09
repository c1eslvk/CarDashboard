using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MusicSliderScript : MonoBehaviour
{
    public Slider slider; // Reference to the Slider UI component
    public TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component

    // Update is called once per frame
    void Update()
    {
        if (slider != null && textMeshPro != null)
        {
            // Calculate total seconds from slider value
            float totalSeconds = slider.value;

            // Calculate minutes and seconds
            int minutes = Mathf.FloorToInt(totalSeconds / 60f);
            int seconds = Mathf.FloorToInt(totalSeconds % 60f);

            // Display the time in 0:00 format
            textMeshPro.text = minutes.ToString("0") + ":" + seconds.ToString("00");
        }
    }
}
