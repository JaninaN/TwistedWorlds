using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTestEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onSignClicked()
    {
        GameObject testText = new GameObject("SonText");
        testText.transform.SetParent(this.transform);
        Text txt = testText.AddComponent<Text>();

        txt.text = "Da sollen wir hin gehen Mama.";

    }
}
