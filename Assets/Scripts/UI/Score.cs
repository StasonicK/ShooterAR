using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scoreDisplay;

    private void OnEnable()
    {
        _player.ScoreUpdated += OnScoreUpdated;
    }

    private void OnDisable()
    {
        _player.ScoreUpdated -= OnScoreUpdated;
    }

    private void OnScoreUpdated(int score)
    {
        _scoreDisplay.text = score.ToString();
    }
}