using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTextUpdater : MonoBehaviour
{
    public Slider slider;
    public TMP_Text textMeshPro;

    private void Start()
    {
        UpdateSliderValueText();
    }

    public void UpdateSliderValueText()
    {
        if (slider != null && textMeshPro != null)
        {
            int sliderValue = Mathf.RoundToInt(slider.value * 99) + 1; // Convert 0-1 to 1-100
            textMeshPro.text = "Chargement" + sliderValue + " %";
        }
    }

    private void OnEnable()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnDisable()
    {
        slider.onValueChanged.RemoveListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        UpdateSliderValueText();
    }
}