using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempButtonScript : MonoBehaviour
{
    public Image tempImage;
    public Sprite tempSprite;
    public Color tempColor = new Color(0.274f, 0.239f, 0.227f); 
    public Sprite tempLightSprite;
    public Color tempLightColor = new Color(0.788f, 0.008f, 0.243f);

    void Start()
    {
        if (tempImage == null)
        {
            Debug.LogError("Oil Image reference not set in the inspector!");
        }
        else
        {
            tempImage.sprite = tempSprite;
            tempImage.color = tempColor;
        }
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    public void OnButtonClick()
    {
        if (tempImage.sprite == tempSprite)
        {
            tempImage.sprite = tempLightSprite;
            tempImage.color = tempLightColor;
        }
        else
        {
            tempImage.sprite = tempSprite;
            tempImage.color = tempColor;
        }
    }
}
