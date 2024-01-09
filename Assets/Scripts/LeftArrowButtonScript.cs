using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftArrowButtonScript : MonoBehaviour
{
    public Image leftArrowImage;
    public Sprite leftArrowSprite;
    public Color leftArrowColor = new Color(0.274f, 0.239f, 0.227f); 
    
    public Sprite leftArrowLightSprite;
    public Color leftArrowLightColor = new Color(0.149f, 0.584f, 0.8f);

    void Start()
    {
        if (leftArrowImage == null)
        {
            Debug.LogError("Left Arrow Image reference not set in the inspector!");
        }
        else
        {
            leftArrowImage.sprite = leftArrowSprite;
            leftArrowImage.color = leftArrowColor;
        }
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    public void OnButtonClick()
    {
        if (leftArrowImage.sprite == leftArrowSprite)
        {
            leftArrowImage.sprite = leftArrowLightSprite;
            leftArrowImage.color = leftArrowLightColor;
        }
        else
        {
            leftArrowImage.sprite = leftArrowSprite;
            leftArrowImage.color = leftArrowColor;
        }
    }
}
