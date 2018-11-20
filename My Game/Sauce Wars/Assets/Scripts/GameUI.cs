using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public int playerScore = 0;
    public int enemyScore = 0;

    public Text playerSceneScoreText;
    public Text enemySceneScoreText;

    public Text PlayerScoreText;
    public Text EnemyScoreText;

    private void OnEnable()
    {
        print("GameUI - OnEnable");

        //AddScore.OnSendScore += UpdateScore;
        AddScore.OnSendScorePlayer += UpdateScorePlayer;
        AddScore.OnSendScoreEnemy += UpdateScoreEnemy;
    }

    private void OnDisable()
    {
        print("GameUI - OnDisable");

        //AddScore.OnSendScore -= UpdateScore;
        AddScore.OnSendScorePlayer -= UpdateScorePlayer;
        AddScore.OnSendScoreEnemy -= UpdateScoreEnemy;
    }

    private void UpdateScorePlayer(int Score)
    {
        print("GameUI - UpdateScorePlayer");

        //print("updating score");
        playerScore += Score;
        PlayerScoreText.text = "SCORE: " + playerScore.ToString();
        playerSceneScoreText.text = playerScore.ToString();
    }

    private void UpdateScoreEnemy(int Score)
    {
        print("GameUI - UpdateScoreEnemy");

        //print("updating score");
        enemyScore += Score;
        EnemyScoreText.text = "ENEMY SCORE: " + enemyScore.ToString();
        enemySceneScoreText.text = enemyScore.ToString();
    }
}
