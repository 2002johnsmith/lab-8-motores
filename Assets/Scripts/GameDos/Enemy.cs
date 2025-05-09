using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ColorData enemyColor;
    [SerializeField] private int damage;
    public static event Action<ColorData, int> OnEnter;
    public static event Action OnExit;

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
