using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        GameManager.Instance.OnScoreUpdated += UpdateScoreText;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnScoreUpdated -= UpdateScoreText;
    }

    private void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score: " + newScore.ToString();
    }
}
