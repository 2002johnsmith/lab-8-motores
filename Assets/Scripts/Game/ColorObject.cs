using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData ColorData;
    private SpriteRenderer SpriteRenderer;
    public static event Action<Color> OnchangeColor;
    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        SetUp();
    }
    public void SetUp()
    {
        SpriteRenderer.color = ColorData.Color;
        SpriteRenderer.sprite = SpriteRenderer.sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("COLOR");
        OnchangeColor?.Invoke(SpriteRenderer.color);
        }
    }
}
