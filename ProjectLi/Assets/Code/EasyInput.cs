using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyInput : MonoBehaviour {

    public InputField mainInputField;
    public int scoreCounter;
    
    // Use this for initialization
    void Start () {
        scoreCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Submission()
    {
        GameObject gen = GameObject.Find("IntegerGenerator");
        ResoureIntegerLoop resourceInts = gen.GetComponent<ResoureIntegerLoop>();
        if (mainInputField.text == resourceInts.answer.ToString())
        {
            Debug.Log("correct");
            resourceInts.Generate();
            mainInputField.text = "";
            scoreCounter++;
        }
    }
}
