using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public int playerScore = 0;
    public int enemyScore = 0;

    //public Text playerSceneScoreText;
    //public Text enemySceneScoreText;

    public delegate void UpdateScore(int theScore);
    public static event UpdateScore UpdateCharacterScore;

    public Text PlayerScoreText;
    public Text EnemyScoreText;

    private void OnEnable()
    {
        print("GameUI - OnEnable");

        //AddScore.OnSendScore += UpdateScore;
        AddScore.OnSendScorePlayer += UpdateScorePlayer;
        AddScore.OnSendScoreEnemy += UpdateScoreEnemy;
        EggAddScore.OnSendScorePlayer += UpdateScorePlayer;
        EggAddScore.OnSendScoreEnemy += UpdateScoreEnemy;
        HashAddScore.OnSendScorePlayer += UpdateScorePlayer;
        HashAddScore.OnSendScoreEnemy += UpdateScoreEnemy;

    }

    private void OnDisable()
    {
        print("GameUI - OnDisable");

        //AddScore.OnSendScore -= UpdateScore;
        AddScore.OnSendScorePlayer -= UpdateScorePlayer;
        AddScore.OnSendScoreEnemy -= UpdateScoreEnemy;
        EggAddScore.OnSendScorePlayer -= UpdateScorePlayer;
        EggAddScore.OnSendScoreEnemy -= UpdateScoreEnemy;
        HashAddScore.OnSendScorePlayer -= UpdateScorePlayer;
        HashAddScore.OnSendScoreEnemy -= UpdateScoreEnemy;

        int currentPlayerScore = PlayerPrefs.GetInt("PlayerScore");
        if (currentPlayerScore != playerScore)
        {
            PlayerPrefs.SetInt("PlayerScore", playerScore);
        }
        int currentEnemyScore = PlayerPrefs.GetInt("EnemyScore");
        if (currentEnemyScore != enemyScore)
        {
            PlayerPrefs.SetInt("EnemyScore", enemyScore);
        }
    }

    private void UpdateScorePlayer(int Score)
    {
        print("GameUI - UpdateScorePlayer");

        //print("updating score");
        playerScore += Score;
        PlayerScoreText.text = "SCORE: " + playerScore.ToString();
        UpdateCharacterScore(playerScore);
        //playerSceneScoreText.text = playerScore.ToString();

        
    }

    private void UpdateScoreEnemy(int Score)
    {
        print("GameUI - UpdateScoreEnemy");

        //print("updating score");
        enemyScore += Score;
        EnemyScoreText.text = "ENEMY SCORE: " + enemyScore.ToString();
        // enemySceneScoreText.text = enemyScore.ToString();
    }

    public int getPlayerScore()
    {
        return playerScore;
    }
    public int getEnemyScore()
    {
        return enemyScore;
    }

}
