using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    public Scene curScene;
    private AudioSource audio;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
 
        DontDestroyOnLoad(this.gameObject);

        curScene = SceneManager.GetActiveScene();

    }

    private void Update()
    {
        curScene = SceneManager.GetActiveScene();

        if (curScene.name == "Game")
            Destroy(this.gameObject);
    }

    private void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        if (curScene.name == "Game")
            Destroy(this.gameObject);
    }
}
