using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilButtonScript : MonoBehaviour
{
    public Image oilImage;
    public Sprite oilSprite;
    public Color oilColor = new Color(0.274f, 0.239f, 0.227f); 
    
    public Sprite oilLightSprite;
    public Color oilLightColor = new Color(0.788f, 0.008f, 0.243f);

    void Start()
    {
        if (oilImage == null)
        {
            Debug.LogError("Oil Image reference not set in the inspector!");
        }
        else
        {
            oilImage.sprite = oilSprite;
            oilImage.color = oilColor;
        }
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    public void OnButtonClick()
    {
        if (oilImage.sprite == oilSprite)
        {
            oilImage.sprite = oilLightSprite;
            oilImage.color = oilLightColor;
        }
        else
        {
            oilImage.sprite = oilSprite;
            oilImage.color = oilColor;
        }
    }
}
