using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOnLock : MonoBehaviour {

    public int number;

    private GameObject riddle;

	// Use this for initialization
	void Start () {
        riddle = GameObject.Find("RiddleArea_1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void nextNumber()
    {
        number = (number + 1) % 10;
        GetComponentInChildren<Text>().text = number.ToString();
        riddle.GetComponent<Riddle_JewelCase>().checkCode();
    }

    public int getNumber()
    {
        return number;
    }
}
