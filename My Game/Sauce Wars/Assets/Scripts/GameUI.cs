using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public int playerScore = 0;
    public int enemyScore = 0;

    public Text PlayerScoreText;
    public Text EnemyScoreText;

    private void OnEnable()
    {
        //AddScore.OnSendScore += UpdateScore;
        AddScore.OnSendScorePlayer += UpdateScorePlayer;
        AddScore.OnSendScoreEnemy += UpdateScoreEnemy;
    }

    private void OnDisable()
    {
        //AddScore.OnSendScore -= UpdateScore;
        AddScore.OnSendScorePlayer -= UpdateScorePlayer;
        AddScore.OnSendScoreEnemy -= UpdateScoreEnemy;
    }

    private void UpdateScorePlayer(int Score)
    {
        //print("updating score");
        playerScore += Score;
        PlayerScoreText.text = "SCORE: " + playerScore.ToString();
    }

    private void UpdateScoreEnemy(int Score)
    {
        //print("updating score");
        enemyScore += Score;
        EnemyScoreText.text = "ENEMY SCORE: " + enemyScore.ToString();
    }
}
