using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightArrowButtonScript : MonoBehaviour
{
    public Image rightArrowImage;
    public Sprite rightArrowSprite;
    public Color rightArrowColor = new Color(0.274f, 0.239f, 0.227f); 
    
    public Sprite rightArrowLightSprite;
    public Color rightArrowLightColor = new Color(0.149f, 0.584f, 0.8f);

    void Start()
    {
        if (rightArrowImage == null)
        {
            Debug.LogError("Oil Image reference not set in the inspector!");
        }
        else
        {
            rightArrowImage.sprite = rightArrowSprite;
            rightArrowImage.color = rightArrowColor;
        }
    }

    void Update()
    {
        // You can add any update logic here if needed
    }

    public void OnButtonClick()
    {
        if (rightArrowImage.sprite == rightArrowSprite)
        {
            rightArrowImage.sprite = rightArrowLightSprite;
            rightArrowImage.color = rightArrowLightColor;
        }
        else
        {
            rightArrowImage.sprite = rightArrowSprite;
            rightArrowImage.color = rightArrowColor;
        }
    }
}
