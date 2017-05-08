using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickTestEvent : MonoBehaviour {

    GameObject talkbox;

	// Use this for initialization
	void Start () {
        talkbox = GameObject.Find("Test_Laberkasten");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("mouse ist unten");
        talkbox.GetComponent<Talkbox_fit_to_situation>().show("Na dann los, da lang. ok?", Resources.Load<Sprite>("Reh_Kopf_Junge_linksblick"));
    }
}
