using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonClickedEvent : MonoBehaviour {

    public Character character;
    GameObject data;

	// Use this for initialization
	void Start () {
        data = GameObject.Find("DataStorage");
	}

    private void OnMouseUpAsButton()
    {
        data.GetComponent<Storyflow>().talkTo(character);
        Debug.Log("Click on " + character.ToString());
    }
}
