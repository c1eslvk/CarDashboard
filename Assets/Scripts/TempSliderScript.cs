using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TempSliderScript : MonoBehaviour
{
    public Slider slider; // Reference to the Slider UI component
    public TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component

    // Update is called once per frame
    void Update()
    {
        if (slider != null && textMeshPro != null)
        {
            // Display the temperature value with degree symbol
            textMeshPro.text = slider.value.ToString("0") + "°";
        }
    }
}
