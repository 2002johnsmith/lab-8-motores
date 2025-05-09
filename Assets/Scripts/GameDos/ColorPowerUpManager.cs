using System;
using System.Security.Cryptography;
using UnityEngine;

public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] colors;
    [SerializeField] private ColorData currentColor;
    [SerializeField] private bool canChangeColor;
    public event Action<ColorData> OnChangeColor;

    public void OnPreviusColor()
    {

    }
    public void OnNextColor()
    {

    }
    public void ChangeColorSelection()
    {

    }
    private void ValdateCollision(ColorData otherColor, int damage)
    {

    }
    private void ReturnToNormal()
    {

    }
}
