using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData PlayerData;
    private SpriteRenderer SpriteRenderer;
    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        ShapeObjects.OnchangeShape += UpDateShape;
        ColorObject.OnchangeColor += UpdateColor;
    }
    private void OnDisable()
    {
        ShapeObjects.OnchangeShape -= UpDateShape;
        ColorObject.OnchangeColor -= UpdateColor;
    }
    private void Start()
    {
        SetUP();
    }
    public void SetUP()
    {
        SpriteRenderer.color = PlayerData.Color;
        SpriteRenderer.sprite = PlayerData.Sprite;
    }
    public void UpdateColor(Color NewColor)
    {
        SpriteRenderer.color = NewColor;
    }
    public void UpDateShape(Sprite NewSprite)
    {
        SpriteRenderer.sprite = NewSprite;
    }
}
