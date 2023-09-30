using UnityEngine;

public class BootStrap : MonoBehaviour
{
    private IAddService _addService;
    private Game _game;

    private void Start()
    {
        _addService = FindObjectOfType<YandexAdd>();
        
        _game = GetComponent<Game>();
        _game.Initialize(_addService);
    }
}
