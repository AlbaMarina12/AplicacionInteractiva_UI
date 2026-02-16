using UnityEngine;
using TMPro;

public class FontControllerTMP : MonoBehaviour
{
    public TMP_Text targetText;
    public float step = 2f;
    public float minSize = 12f;
    public float maxSize = 60f;

    public void IncreaseSize()
    {
        if (targetText == null) return;
        targetText.fontSize = Mathf.Min(targetText.fontSize + step, maxSize);
    }

    public void DecreaseSize()
    {
        if (targetText == null) return;
        targetText.fontSize = Mathf.Max(targetText.fontSize - step, minSize);
    }
}
