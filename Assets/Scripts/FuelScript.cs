using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    public Image fuelBar;
    public Image[] fuelPoints;
    public Slider fuelSlider;
    public Image fuelImage;
    public Sprite fulFuelSprite;
    public Sprite emptyFuelSprite;

    float maxFuelPoints = 10;
    float criticalFuelPercentage = 0.2f;

    private void Start() {
        fuelImage.color = new Color(0.274f, 0.239f, 0.227f);
        fuelImage.sprite = fulFuelSprite;
        fuelSlider.onValueChanged.AddListener(delegate { OnFuelValueChanged(); });
        UpadteFuelBar();
    }

    private void OnFuelValueChanged() {
        UpadteFuelBar();
        UpdateFuelIcon();
    }

    void UpadteFuelBar() {
        int displayedFuelPoints = Mathf.CeilToInt(fuelSlider.value * maxFuelPoints);

        for (int i = 0; i < fuelPoints.Length; i++) {
            fuelPoints[i].enabled = i < displayedFuelPoints;
        }
    }

    void UpdateFuelIcon() {
        float fuelPercentage = fuelSlider.value;
        if (fuelPercentage <= criticalFuelPercentage) {
            fuelImage.color = new Color(1f, 0.392f, 0f);
            fuelImage.sprite = emptyFuelSprite;
        } else {
            fuelImage.color = new Color(0.274f, 0.239f, 0.227f);
            fuelImage.sprite = fulFuelSprite;
        }
    }
}
