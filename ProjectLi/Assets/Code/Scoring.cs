using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour {

    public Text score;
    public Text timer;
    public float time;
    public string timerFormatted;
    public GameObject manager;
    public int scoreFinal;

    // Use this for initialization
    void Start() {
        DontDestroyOnLoad(this);
        score.text = "0";
        timer.text = "Time: 2:00";
        time = 120;
    }

    // Update is called once per frame
    void Update() {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject input = GameObject.Find("InputField");
            EasyInput inputs = input.GetComponent<EasyInput>();

            GameObject gen = GameObject.Find("IntegerGenerator");
            ResoureIntegerLoop resourceInts = gen.GetComponent<ResoureIntegerLoop>();

            time -= Time.deltaTime;
            var timerFormatted = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);
            timer.text = "Time: " + timerFormatted;
            score.text = "Score: " + inputs.scoreCounter;
            scoreFinal = inputs.scoreCounter;
            if (time <= 0)
            {
                Debug.Log("timeout");
                timeOut();
            }
        }

    }

    public void timeOut()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
