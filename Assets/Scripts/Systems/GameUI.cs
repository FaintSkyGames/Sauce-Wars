using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public int playerScore = 0;
    public int enemyScore = 0;

    public int scoreToAdd;

    public delegate void UpdateScore(int theScore);
    public static event UpdateScore UpdateCharacterScore;

    public Text PlayerScoreText;
    public Text EnemyScoreText;

    // On enable set the text and scores
    private void OnEnable()
    {
        EnemyScoreText.text = "ENEMY SCORE: " + playerScore;
        PlayerScoreText.text = "PLAYER SCORE: " + enemyScore;


        //AddScore.OnSendScore += UpdateScore;

        AddScore.OnSendScorePlayer += UpdateScorePlayer;
        AddScore.OnSendScoreEnemy += UpdateScoreEnemy;
                
        EggAddScore.OnSendScorePlayer += UpdateScorePlayer;
        EggAddScore.OnSendScoreEnemy += UpdateScoreEnemy;


        HashAddScore.OnSendScorePlayer += UpdateScorePlayer;
        HashAddScore.OnSendScoreEnemy += UpdateScoreEnemy;


    }

    // On disable ensure all scores are added and player prefs updated
    private void OnDisable()
    {
        //AddScore.OnSendScore -= UpdateScore;

        AddScore.OnSendScorePlayer -= UpdateScorePlayer;
        AddScore.OnSendScoreEnemy -= UpdateScoreEnemy;
        EggAddScore.OnSendScorePlayer -= UpdateScorePlayer;
        EggAddScore.OnSendScoreEnemy -= UpdateScoreEnemy;

        HashAddScore.OnSendScorePlayer -= UpdateScorePlayer;
        HashAddScore.OnSendScoreEnemy -= UpdateScoreEnemy;

        PlayerPrefs.SetInt("PlayerScore", playerScore);
        PlayerPrefs.SetInt("EnemyScore", enemyScore);
    }

    // When a score is passed from the target update the player score
    private void UpdateScorePlayer(int Score)
    {
        playerScore += Score;
        PlayerScoreText.text = "SCORE: " + playerScore.ToString();
        UpdateCharacterScore(playerScore);
     }

    // When a score is passed from the target update the enemy score
    private void UpdateScoreEnemy(int Score)
    {
        enemyScore += Score;
        EnemyScoreText.text = "ENEMY SCORE: " + enemyScore.ToString();
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
