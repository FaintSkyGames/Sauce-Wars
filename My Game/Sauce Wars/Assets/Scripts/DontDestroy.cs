using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	// Called before start
	void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
