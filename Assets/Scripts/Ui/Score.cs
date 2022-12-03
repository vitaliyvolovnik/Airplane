using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private Coin _coin;

    private int _scoreValue;
    

    public int ScoreValue { get { return _scoreValue; } }

    private void OnEnable()
    {
        Coin.PickCoin += OnPickCoin;
    }

    private void OnDisable()
    {
        Coin.PickCoin -= OnPickCoin;
    }

    public void OnPickCoin()
    {
        _scoreValue++;
        _score.text = _scoreValue.ToString();

    }

}
