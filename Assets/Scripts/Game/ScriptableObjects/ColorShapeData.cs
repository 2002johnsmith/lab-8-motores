using UnityEngine;

[CreateAssetMenu(fileName = "color shape data", menuName = "scriptable Objects/Game 1/ColorShapeData")]

public class ColorShapeData : ScriptableObject
{
    [SerializeField] private Color _color;
    [SerializeField] private Sprite sprite;
    public Color Color => _color;
    public Sprite Sprite => sprite;
}
