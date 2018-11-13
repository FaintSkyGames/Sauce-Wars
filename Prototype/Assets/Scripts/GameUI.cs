using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Referances the slider
    public Slider healthBar;
    public Text scoreText;
    public int playerScore = 0;

    // When a gameobject is created
    private void OnEnable()
    {
        // Sets the health bar to match players health
        Player.OnUpdateHealth += UpdateHealthBar;
        // Updates score
        AddScore.OnSendScore += UpdateScore;
    }

    // When a gameobject is disabled
    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
    }

    // sets the health bar to be the same as player health
    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }

    // Updates the score and text
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "SCORE: " + theScore.ToString();
    }
}