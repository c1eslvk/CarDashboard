using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSliderScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI digit1;
    [SerializeField] private TextMeshProUGUI digit2;
    [SerializeField] private TextMeshProUGUI digit3;
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            UpdateDigitText(v);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateDigitText(float sliderValue) {

        string formattedValue = ((int)sliderValue).ToString("000");

        digit1.text = formattedValue[0].ToString();
        digit2.text = formattedValue[1].ToString();
        digit3.text = formattedValue[2].ToString();
    }
}
