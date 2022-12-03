using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStateChecker : MonoBehaviour
{
    [SerializeField] private EndGameScreen _screen;


    private void OnEnable() => Bomb.GameEnd += OnGameEnd;

    private void OnDisable() => Bomb.GameEnd -= OnGameEnd;




    private void OnGameEnd()
    {
        _screen.gameObject.SetActive(true);
    }
}
