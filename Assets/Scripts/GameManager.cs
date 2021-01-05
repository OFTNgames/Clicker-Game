using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ScoreManager _scoreManager;
    private float _timer = 0;

    private void Awake() => _scoreManager = GetComponent<ScoreManager>();
   
    private void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= UpgradeStats.PassiveRate)
        {
            _scoreManager.ChangeScore(UpgradeStats.PassiveAmount);
            _timer = 0;
        }
    }
}
