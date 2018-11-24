using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManagement library
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject playerScore;
    public GameObject enemyScore;

    private Scene sceneToLoad;


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

        sceneToLoad = SceneManager.GetSceneByName("Game Over");
        // Loads the Game Over scene
        SceneManager.LoadScene("Game Over");
        DontDestroyOnLoad(playerScore);
        DontDestroyOnLoad(enemyScore);
    }

    public void BackToMainMenu()
    {
        print("GameManager - BackToMainMenu");

        // Loads the Main Menu scene
        SceneManager.LoadScene("Main Menu");

    }
}