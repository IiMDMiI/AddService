using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] private Button _interstitial;
    [SerializeField] private Button _rewarded;
    [SerializeField] private TextMeshProUGUI _logs;

    private IAddService _addService;
    public void Initialize(IAddService addService)
    {
        _addService = addService;

        _interstitial.onClick.AddListener(_addService.ShowInterstitial);

        _addService.RewardedAddFinished += () => _logs.text = "Reward!";
        _rewarded.onClick.AddListener(_addService.ShowRewarded);
    }
}
