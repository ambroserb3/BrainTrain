using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {


    public Text endscore;

	// Use this for initialization
	void Start () {
        GameObject score = GameObject.Find("ScoreManager");
        Scoring scores = score.GetComponent<Scoring>();
        endscore.text = "Your Score:  " + scores.scoreFinal;
        //Destroy(score);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
