using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoureIntegerLoop : MonoBehaviour {

    public int randomInteger;
    public int randomInteger2;

    public GameObject integer;
    public GameObject integer2;
    public Vector3 intOffset;

    public int arithmetic1;
    public int arithmetic2;
    public int answer;

    // Use this for initialization
    void Start () {
        intOffset = new Vector3(4, 0, 0);
        Generate();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
        }
    }

    public void Solution()
    {
        answer = arithmetic1 + arithmetic2;
        Debug.Log(answer);
    }

    public void Generate()
    {
        Object.Destroy(integer);
        Object.Destroy(integer2);

        randomInteger = Random.Range(1, 10); //Random int 1-9 (10 is excluded)
        integer = Resources.Load(randomInteger.ToString()) as GameObject;
        Debug.Log(randomInteger);

        randomInteger2 = Random.Range(1, 10); //Random int 1-9 (10 is excluded)
        integer2 = Resources.Load(randomInteger2.ToString()) as GameObject;
        Debug.Log(randomInteger2);

        integer = Instantiate(integer, transform.position, transform.rotation) as GameObject;
        integer2 = Instantiate(integer2, transform.position + intOffset, transform.rotation) as GameObject;

        arithmetic1 = randomInteger;
        arithmetic2 = randomInteger2;

        Solution();
    }
 

}
