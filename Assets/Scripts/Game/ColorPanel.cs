using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    private Image ColorImage;
    void Awake()
    {
        ColorImage = GetComponent<Image>();
    }
    private void OnEnable()
    {
        ColorObject.OnchangeColor += UpDateColor;
    }
    private void OnDisable()
    {
        ColorObject.OnchangeColor -= UpDateColor;
    }
    public void UpDateColor(Color Newcolor)
    {
        ColorImage.color = Newcolor;
    }
}
