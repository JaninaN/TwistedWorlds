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

    public void clickOnPerson()
    {
        if(data.GetComponent<Storyflow>().getGameState() == GameState.Idle)
        {
            data.GetComponent<Storyflow>().talkTo(character);
            Debug.Log("idle");
        }
        
        Debug.Log("Click on " + character.ToString());
    }
}
