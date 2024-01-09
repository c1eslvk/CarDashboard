using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryButtonScript : MonoBehaviour
{
    public Image batteryImage;
    public Sprite batterySprite;
    public Color batteryColor = new Color(0.274f, 0.239f, 0.227f); 
    
    public Sprite batteryLightSprite;
    public Color batteryLightColor = new Color(0.788f, 0.008f, 0.243f);

    void Start()
    {
        if (batteryImage == null)
        {
            Debug.LogError("Oil Image reference not set in the inspector!");
        }
        else
        {
            batteryImage.sprite = batterySprite;
            batteryImage.color = batteryColor;
        }
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    public void OnButtonClick()
    {
        if (batteryImage.sprite == batterySprite)
        {
            batteryImage.sprite = batteryLightSprite;
            batteryImage.color = batteryLightColor;
        }
        else
        {
            batteryImage.sprite = batterySprite;
            batteryImage.color = batteryColor;
        }
    }
}
