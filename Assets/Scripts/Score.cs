using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text txtScore;
    [SerializeField]
    int currentScore;

    void Awake()
    {
        txtScore = GetComponent<Text>();
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        txtScore.text = $"Score: {currentScore} pts";
    }
}
