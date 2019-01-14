using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    public AudioClip gameMusic;
    public AudioClip menuMusic;

    public Scene curScene;
    public Scene prevScene;
    private AudioSource audio;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
 
        DontDestroyOnLoad(this.gameObject);

        curScene = SceneManager.GetActiveScene();
        print("This scene is " + curScene.name);

        if (curScene != prevScene)
        {
            ChangeMusic();
            prevScene = curScene;
        }
    }

    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        curScene = SceneManager.GetActiveScene();
        prevScene = curScene;

        if (curScene.name == "Game")
        {
                audio.clip = null;
        }
        else
        {
            audio.Stop();
            audio.clip = menuMusic;
            audio.Play();
        }
    }

    private void ChangeMusic()
    {

        if (curScene.name == "Game")
        {
            audio.Stop();
        }
        else
        {
            audio.Play();
        }
    }

}
