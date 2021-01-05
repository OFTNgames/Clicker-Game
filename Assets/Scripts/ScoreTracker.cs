using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private TMP_Text _text;

    private void OnEnable()
    {
        ScoreManager.ScoreChange += UpdateScoreDisplay;
        _text = GetComponent<TMP_Text>();
    }

    private void UpdateScoreDisplay(int score)
    {
        _text.text = score.ToString();
    }

    private void OnDisable()
    {
        ScoreManager.ScoreChange -= UpdateScoreDisplay;
    }
}
