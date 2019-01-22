using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("EnemyScore") < PlayerPrefs.GetInt("PlayerScore"))
            GetComponent<Text>().text = "Congratulations, you won!";
         else
            GetComponent<Text>().text = "Better luck next time.";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
