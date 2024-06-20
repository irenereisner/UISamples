using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [Range(0, 1)]
    [SerializeField]
    private float progress = 0.0f;

    [SerializeField]
    private int discreteSteps = 0;

    [SerializeField]
    private List<Image> images;
    [SerializeField]
    private List<TMPro.TextMeshProUGUI> texts;
    
    void Update()
    {
        var visibleProgress = progress;
        if (discreteSteps != 0)
        {
            visibleProgress = Mathf.Floor(progress * discreteSteps) / discreteSteps;
        }
        
        foreach (var image in images)
        {
            image.fillAmount = visibleProgress;
        }

        foreach (var text in texts)
        {
            text.text = (visibleProgress * 100).ToString("F0");
        }
    }
    
    public void SetProgress(string intValue)
    {
        if (int.TryParse(intValue, out int value))
        {
            progress = value / 100.0f;
        }
    }
    
    public void SetProgress(int value)
    {
        progress = Clamp(value / 100.0f);
    }
    
    public void SetProgress(float value)
    {
        progress = Clamp(value);
    }

    public void Decrease(float value)
    {
        progress = Clamp(progress - value);
    }
    
    public void Increase(float value)
    {
        progress = Clamp(progress + value);
    }

    private static float Clamp(float value)
    {
        return Mathf.Clamp(value, 0, 1);
    }
}
