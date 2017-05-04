using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTestEvent : MonoBehaviour {

    GameObject canvas, talkbox;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");
        talkbox = GameObject.Find("Test_Laberkasten");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onSignClicked()
    {
        Debug.Log("gedrüüückt");
        RectTransform can = canvas.GetComponent<RectTransform>();
        RectTransform sr = talkbox.GetComponent<RectTransform>();
        can.SetSiblingIndex(10);
        sr.SetSiblingIndex(5);
        Canvas can2 = canvas.GetComponent<Canvas>();
        SpriteRenderer sr2 = talkbox.GetComponent<SpriteRenderer>();
    }
}
