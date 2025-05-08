using System;
using UnityEngine;

public class ShapeObjects : MonoBehaviour
{
    [SerializeField] private ColorShapeData shapeData;
    private SpriteRenderer spriteRenderer;
    public static event Action<Sprite> OnchangeShape;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetUp();
    }
    public void SetUp()
    {
        spriteRenderer.color = shapeData.Color;
        spriteRenderer.sprite = shapeData.Sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("FORMAA");
            OnchangeShape?.Invoke(spriteRenderer.sprite);
        }
    }
}
