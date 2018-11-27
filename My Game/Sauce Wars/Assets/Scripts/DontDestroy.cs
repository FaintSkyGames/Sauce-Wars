using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    public GameObject txt;

	// Called before start
	void Awake()
    {
        DontDestroyOnLoad(txt);
    }
}
