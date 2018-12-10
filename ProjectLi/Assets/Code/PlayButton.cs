using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToPlay()
    {
        SceneManager.LoadScene(1);
    }


    public void GoToHow()
    {
        SceneManager.LoadScene(3);
    }

    public void End()
    {
        Application.Quit();
    }
}
