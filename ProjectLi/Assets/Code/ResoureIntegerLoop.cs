using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoureIntegerLoop : MonoBehaviour {

    public int randomInteger;
    public int randomInteger2;
    public int randomInteger3;


    public GameObject integer;
    public GameObject integer2;
    public GameObject sign;

    public Vector3 intOffset;
    public Vector3 signOffset;


    public int arithmetic1;
    public int arithmetic2;
    public int mathSign;

    public int answer;

    public string[] signs;

    // Use this for initialization
    void Start () {
        intOffset = new Vector3(4, 0, 0);
        signOffset = new Vector3(2, 0, 0);

        Generate();
        //TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad, false, false, false, false, "Answer", 4);
    }

    // Update is called once per frame
    void Update () {

    }

    public void Solution()
    {
        switch (mathSign)
        {
            case 0:
                answer = arithmetic1 + arithmetic2;
                break;
            case 1:
                answer = arithmetic1 - arithmetic2;
                break;
            case 2:
                answer = arithmetic1 * arithmetic2;
                break;
            default:
                answer = arithmetic1 + arithmetic2;
                break;
        }
        Debug.Log(answer);
    }


    public void Generate()
    {
        signs = new string[3];
        signs[0] = "plus";
        signs[1] = "subtract";
        signs[2] = "multiply";
        Object.Destroy(integer);
        Object.Destroy(integer2);
        Object.Destroy(sign);

        randomInteger = Random.Range(1, 10); //Random int 1-9 (10 is excluded)
        integer = Resources.Load(randomInteger.ToString()) as GameObject;
        Debug.Log(randomInteger);

        randomInteger3 = Random.Range(0, 3); //Random int 0-2 
        Debug.Log(signs[randomInteger3]);
        sign = Resources.Load(signs[randomInteger3]) as GameObject;
        //Debug.Log("sign");

        randomInteger2 = Random.Range(1, 10); //Random int 1-9 (10 is excluded)
        integer2 = Resources.Load(randomInteger2.ToString()) as GameObject;
        Debug.Log(randomInteger2);

        integer = Instantiate(integer, transform.position, transform.rotation) as GameObject;
        sign = Instantiate(sign, transform.position + signOffset, transform.rotation) as GameObject;
        integer2 = Instantiate(integer2, transform.position + intOffset, transform.rotation) as GameObject;

        arithmetic1 = randomInteger;
        arithmetic2 = randomInteger2;
        mathSign = randomInteger3;


        Solution();
        Debug.Log("Gen");

    }


}
