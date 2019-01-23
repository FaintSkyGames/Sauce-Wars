using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManagement library
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    private Scene sceneToLoad;


    // All methods are public so that buttons can use them

    public void StartGame()
    {
        // Loads the Game scene
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        // Loads the Game Over scene
        SceneManager.LoadScene("Game Over");
    }

    public void BackToMainMenu()
    {
        // Loads the Main Menu scene
        SceneManager.LoadScene("Main Menu");
    }

    public void Instructions()
    {
        // Loads the instructions
        SceneManager.LoadScene("Instructions");
    }

    public void Quit()
    {
        // Ends the program
        Application.Quit();
    }

}