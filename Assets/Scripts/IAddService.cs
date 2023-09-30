using System;

public interface IAddService 
{    
    public void ShowBanner();
    public void ShowInterstitial();
    public void ShowRewarded();
    public event Action RewardedAddFinished;
}
