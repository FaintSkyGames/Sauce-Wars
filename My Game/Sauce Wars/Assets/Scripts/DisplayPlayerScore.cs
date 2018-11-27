using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerScore : MonoBehaviour {



	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "Player Score: " + PlayerPrefs.GetInt("PlayerScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
