using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int PlayerLife;
    [SerializeField] private int PlayerCoins;
    public static event Action<int> OnLifeUpdate;
    public static event Action<int> OnCoinUpdate;
    public static event Action OnWin;
    public static event Action OnLoose;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    public void GainCoin()
    {
        PlayerCoins++;
        OnCoinUpdate?.Invoke(PlayerCoins);
      
    }
    public void ModifyLife(int Modify)
    {
        PlayerLife = PlayerLife + Modify;
        OnLifeUpdate?.Invoke(PlayerLife);
    }
    public void CheckWin()
    {
        OnWin?.Invoke();
    } 
    private void ValidateLife()
    {
        if (PlayerLife <= 0)
        {
            OnLoose?.Invoke();
        }
    }
}
