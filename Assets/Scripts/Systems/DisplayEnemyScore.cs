using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEnemyScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "Enemy Score: " + PlayerPrefs.GetInt("EnemyScore").ToString();
    }

}
