using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManagement library
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    // All methods are public so that buttons can use them

    public void StartGame()
    {
        print("GameManager - StartGame");

        // Loads the Game scene
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        print("GameManager - EndGame");

        // Loads the Game Over scene
        SceneManager.LoadScene("Game Over");
    }

    public void BackToMainMenu()
    {
        print("GameManager - BackToMainMenu");

        // Loads the Main Menu scene
        SceneManager.LoadScene("Main Menu");
    }
}