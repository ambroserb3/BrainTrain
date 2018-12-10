using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

    public AudioSource theme;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(theme);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
