using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class YandexAdd : MonoBehaviour, IAddService
{   
    public void ShowInterstitial() => 
        ShowInterstitialExtern();
    public void ShowRewarded() => 
        ShowRewardedExtern();
    public event Action RewardedAddFinished;

    public void OnRewardAddFinished() => 
        RewardedAddFinished?.Invoke();

    public void ShowBanner()
    {
        throw new System.NotImplementedException();
    }

    [DllImport("__Internal")]
    private static extern void ShowInterstitialExtern();

    [DllImport("__Internal")]
    private static extern void ShowRewardedExtern();

}
