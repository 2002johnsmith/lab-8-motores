using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    private Image ShapeImage;
    private void Awake()
    {
        ShapeImage = GetComponent<Image>();
    }
    private void OnEnable()
    {
        ShapeObjects.OnchangeShape += UpdateShape;
    }
    private void OnDisable()
    {
        ShapeObjects.OnchangeShape -= UpdateShape;
    }
    public void UpdateShape(Sprite NewShape)
    {
        ShapeImage.sprite = NewShape;
    }
}
