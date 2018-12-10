using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour {
    public AudioSource Theme;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToPlay()
    {
        GameObject theme = GameObject.Find("Theme");
        Destroy(theme);
        SceneManager.LoadScene(0);
    }
}
