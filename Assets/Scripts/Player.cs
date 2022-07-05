using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _score = 0;

    public event UnityAction<int> ScoreUpdated;

    public void AddScore()
    {
        _score++;
        ScoreUpdated?.Invoke(_score);
    }
}