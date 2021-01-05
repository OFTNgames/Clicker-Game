using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static event System.Action<int> ScoreChange;

    void Start()
    {
        ScoreAmount.Score = PlayerPrefs.GetInt("Score");
        ScoreChange?.Invoke(ScoreAmount.Score);
    }

    public void ChangeScore()
    {
        ScoreAmount.Score += UpgradeStats.ClickPower;
        ScoreChange?.Invoke(ScoreAmount.Score);
    }

    public void ChangeScore(int amount)
    {
        ScoreAmount.Score += amount;
        ScoreChange?.Invoke(ScoreAmount.Score);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Score", ScoreAmount.Score);
    }
}
