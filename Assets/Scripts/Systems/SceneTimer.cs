using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTimer : MonoBehaviour {

    public Slider slider;

    // Scene want to load
    public string sceneName = "Game Over";

    // time after this script initializes, in seconds,
    // that the scene transition will happen
    public float timeLimit = 120f;

    // timer variable
    private float timer = 0f;

    // Set the timer value and set the current time to 0
    void Start()
    {
        slider.maxValue = timeLimit;
        PlayerPrefs.SetFloat("TimeCompleted", 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetFloat("TimeCompleted") < 0)
        {
            PlayerPrefs.SetFloat("TimeCompleted", 0);
        }

        // deltaTime is the time (measured in seconds) since the previous Update step
        // it's typically very small, e.g. 1/60th of a second ~= 0.0167F
        PlayerPrefs.SetFloat("TimeCompleted", (PlayerPrefs.GetFloat("TimeCompleted") + Time.deltaTime));

        slider.value = PlayerPrefs.GetFloat("TimeCompleted");


        // check if it's time to switch scenes
        if (PlayerPrefs.GetFloat("TimeCompleted") >= timeLimit)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
