using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    public Scene curScene;
    private AudioSource audio;

    // Ensures there is only 1 music object and makes sure the music plays continously
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
 
        DontDestroyOnLoad(this.gameObject);

        curScene = SceneManager.GetActiveScene();

    }

    // If the scene is the main game destroy the game object so only 1 piece plays
    private void Update()
    {
        curScene = SceneManager.GetActiveScene();

        if (curScene.name == "Game")
            Destroy(this.gameObject);
    }

    // If the scene is the main game destroy the game object so only 1 piece plays
    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        if (curScene.name == "Game")
            Destroy(this.gameObject);
    }
}
